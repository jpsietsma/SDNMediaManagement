using SDNMediaModels.DBContext;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;
using MediaMaintenanceLibrary.Config;

namespace MediaMaintenanceLibrary.SortProcessing
{
    /// <summary>
    /// Class that handles unprocessed sort items
    /// </summary>
    public static class SortMediaFilenames
    {

        /// <summary>
        /// Process the file contents of the sort directory
        /// </summary>
        /// <param name="sortPath">Path to the sort directory</param>
        /// <returns>list of strings containing junk files</returns>
        public static List<string> ProcessJunk(string sortPath)
        {

            List<string> finalList = new List<string>();

            List<string> junkExtension = new List<string> { ".jpeg", ".txt", ".nfo", ".srt", ".url", ".lnk" };

            string[] tmpItems = Directory.GetFiles(sortPath);

            foreach (string file in tmpItems)
            {
                if (junkExtension.Contains(file.Split('.').Last()))
                {

                    finalList.Add(file);

                }
            }

            return finalList;
        }

        /// <summary>
        /// Sanitize file name of sort media item
        /// </summary>
        /// <param name="filename">Path to the file we want to sanitize</param>
        /// <returns>Sanitized name of file</returns>
        public static string SanitizeSortTitle(string filename)
        {
            string sanitizedName = string.Empty;

            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTitle.ps1 -filename '" + filename + "'";
                PowerShellInstance.AddScript(scriptPath);

                ICollection<PSObject> ps = PowerShellInstance.Invoke();

                foreach (PSObject item in ps)
                {

                    sanitizedName += item.ImmediateBaseObject.ToString();
                }

            }

            return sanitizedName;
        }

        /// <summary>
        /// Get File size
        /// </summary>
        /// <param name="filePath">string path of file to query for file size</param>
        /// <returns>size of file in bytes</returns>
        public static long GetFileSize(string filePath)
        {
            long finalSize;

            FileInfo info = new FileInfo(filePath);
            finalSize = info.Length;

            return finalSize;
        }

        /// <summary>
        /// Get total file size of show, season, or individual episodes
        /// </summary>
        /// <param name="showName">Name of show to limit filesizes to</param>
        /// <param name="seasonNumber">Number of season to limit filesize of episodes to</param>
        /// <param name="episodeNumber">Number of single episode of which to get filesize</param>
        /// <returns>long int total filesizes in bytes</returns>
        public static long GetFileSize(string showName, int? seasonNumber, int? episodeNumber)
        {
            long finalSize = 0;

            using (MediaManagerDB db = new MediaManagerDB())
            {
                foreach (TelevisionShow show in db.TelevisionShows.Where(s => s.ShowName == showName))
                {
                    if (!seasonNumber.HasValue)
                    {
                        foreach (TelevisionSeason season in show.TelevisionSeasons)
                        {
                            foreach (TelevisionEpisode episode in season.TelevisionEpisodes)
                            {
                                FileInfo info = new FileInfo(episode.EpisodePath);

                                finalSize += info.Length;
                            }
                                                     
                        }
                    }
                    else
                    {
                        foreach (TelevisionSeason season in show.TelevisionSeasons.Where(s => s.SeasonNum == seasonNumber))
                        {
                            if (!episodeNumber.HasValue)
                            {
                                foreach (TelevisionEpisode episode in season.TelevisionEpisodes)
                                {
                                    FileInfo info = new FileInfo(episode.EpisodePath);

                                    finalSize += info.Length;
                                }
                            }
                            else
                            {
                                foreach (TelevisionEpisode episode in season.TelevisionEpisodes.Where(e => e.EpisodeNum == episodeNumber))
                                {
                                    FileInfo info = new FileInfo(episode.EpisodePath);

                                    finalSize += info.Length;
                                }
                            }                            
                        }
                    }                                        
                }              
            }            

            return finalSize;
        }

        /// <summary>
        /// Get File size
        /// </summary>
        /// <param name="uSort">model representing sort item to query for file size</param>
        /// <returns>size of file in bytes</returns>
        public static long GetFileSize(this sortItem uSort)
        {
            long finalSize;

            FileInfo info = new FileInfo(uSort.filePath);
            finalSize = info.Length;

            return finalSize;
        }

        /// <summary>
        /// Get Episode File Size
        /// </summary>
        /// <param name="uEpisode">episode model to query for file size</param>
        /// <returns>size of file in bytes</returns>
        public static long GetFileSize(this TelevisionEpisode uEpisode)
        {
            long finalSize;

            FileInfo info = new FileInfo(uEpisode.EpisodePath);
            finalSize = info.Length;

            return finalSize;
        }
        
        /// <summary>
        /// Get sum of file size of all episodes in season
        /// </summary>
        /// <param name="uSeason">Season to sum episode file sizes</param>
        /// <returns>long int total bytes of all episodes</returns>
        public static long SeasonFileSize(this TelevisionSeason uSeason)
        {
            long finalSize = 0;

            using (MediaManagerDB db = new MediaManagerDB())
            {
                foreach (TelevisionEpisode episode in (uSeason.TelevisionEpisodes))
                {
                    finalSize += episode.GetFileSize();
                }

                return finalSize;
            }           
        }

        /// <summary>
        /// Get total file size of all show episodes
        /// </summary>
        /// <param name="uShow">Show to sum episode file sizes</param>
        /// <param name="seasonNumber">optional season number to limit sum of episode filesizes to</param>
        /// <param name="episodeNumber">optional number of single episode of which to get filesize</param>
        /// <returns>long int total bytes of all episodes for show</returns>
        public static long ShowFileSize(this TelevisionShow uShow, int? seasonNumber, int? episodeNumber)
        {
            long finalSize = 0;

            using (MediaManagerDB db = new MediaManagerDB())
            {
                foreach (TelevisionShow show in db.TelevisionShows.Where(s => s.ShowName == uShow.ShowName))
                {
                    if (!seasonNumber.HasValue)
                    {
                        foreach (TelevisionSeason season in show.TelevisionSeasons)
                        {
                            finalSize += season.SeasonFileSize();
                        }
                    }
                    else
                    {
                        foreach (TelevisionSeason season in show.TelevisionSeasons.Where(s => s.SeasonNum == seasonNumber))
                        {
                            if (!episodeNumber.HasValue)
                            {
                                finalSize += season.SeasonFileSize();
                            }
                            else
                            {
                                foreach (TelevisionEpisode episode in season.TelevisionEpisodes.Where(e => e.EpisodeNum == episodeNumber))
                                {
                                    finalSize += GetFileSize(episode.EpisodePath);
                                }
                            }                            
                        }
                    }
                    
                }
            }

            return finalSize;
        }

        /// <summary>
        /// Get Show Name from unsanitized file name
        /// </summary>
        /// <param name="filename">Filename from which to extract Show Name</param>
        /// <param name="delimiter">Character that separates words in filename</param>
        /// <returns></returns>
        public static string GetShowFromFileName(this string filename, char delimiter = '.')
        {
            string finalShow = string.Empty;
            string file = filename;

            if (delimiter == '.')
            {
                Regex pattern = new Regex(MediaManagerConfiguration.TelevisionDottedRegexPattern);
            }
            else
            {
                Regex pattern = new Regex(MediaManagerConfiguration.TelevisionSpacedRegexPattern);
            }            

            return finalShow;
        }


        public static long FreeDriveSpace(string driveLetter)
        {
            long finalFree = -1;

            foreach (DriveInfo info in DriveInfo.GetDrives())
            {
                if (info.IsReady && info.Name == driveLetter)
                {
                    finalFree = info.AvailableFreeSpace;
                }                        
            }

            return finalFree;
        }

    }
}
