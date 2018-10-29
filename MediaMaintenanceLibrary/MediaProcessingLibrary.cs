using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;


namespace MediaMaintenanceLibrary
{

    /// <summary>
    /// Methods for processing media files
    /// </summary>
    public static class MediaProcessingLibrary
    {

#region Sort Folder functions...

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

            //Gather junk and add full paths to finalList list

            return finalList;
        }

        //public static async bool MoveSortFile(List<object> sortMoveList)
        //{


        //    return true;
        //}

        /// <summary>
        /// Get a list of the seasons belonging to the show
        /// </summary>
        /// <param name="id">Id of the show to get seasons</param>
        /// <returns>List of strings representing season names of the show</returns>
        public static List<object> GetShowSeasons(int id)
        {
            List<object> finalSeasons = null;


            return finalSeasons;
        }

        /// <summary>
        /// Get list of episodes belonging to the season
        /// </summary>
        /// <param name="id">Id of the season to get episodes</param>
        /// <returns>list of string representing episodes belonging to the season</returns>
        public static List<object> GetShowSeasonEpisodes(int id)
        {
            List<object> finalEpisodes = null;


            return finalEpisodes;
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
                string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTitle.ps1 -filename '" + filename + "'" ;
                PowerShellInstance.AddScript(scriptPath);

                ICollection <PSObject> ps = PowerShellInstance.Invoke();

                foreach(PSObject item in ps)
                {

                    sanitizedName += item.ImmediateBaseObject.ToString();
                }

            }

            return sanitizedName;
        }

        // SORT processing step 1
        /// <summary>
        /// Populates the 'sortitems' table in the database
        /// </summary>
        /// <param name="drive">path to the sort drive folder to scan into database</param>
        /// <returns>true on success, false on fail</returns>
        public static bool PopulateSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\PopulateSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);
                    PowerShellInstance.AddParameter("Path", drive);
                    PowerShellInstance.Invoke();
                }
                catch(Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        //SORT processing step 2
        /// <summary>
        /// Sanitize the file names of files in the sort folder
        /// </summary>
        /// <param name="drive">Path to the sort folder to sanitize</param>
        /// <returns>true on success, false on fail</returns>
        public static bool SanitizeSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try
                {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);

                    //PowerShellInstance.AddParameter("FileName", fileName);

                    PowerShellInstance.Invoke();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        //SORT processing step 3
        /// <summary>
        /// Finalizes the contents of the sort table for distribution
        /// </summary>
        /// <param name="drive">Path to the sort folder to finalize</param>
        /// <returns>True on success, false on fail</returns>
        public static bool FinalizeSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try
                {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);

                    //PowerShellInstance.AddParameter("FileName", fileName);

                    PowerShellInstance.Invoke();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        //SORT processing step 4
        /// <summary>
        /// Moves finalized files to the live media library after finalized
        /// </summary>
        /// <param name="drive">Path to the sort folder</param>
        /// <returns>True on success, false on fail</returns>
        public static bool DistributeSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try
                {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);

                    //PowerShellInstance.AddParameter("FileName", fileName);

                    PowerShellInstance.Invoke();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        #endregion

#region Storage functions...
    
    /// <summary>
    /// Get Free Space on hard drive
    /// </summary>
    /// <param name="driveLetter">letter of drive to check free space</param>
    /// <returns>decimal representing free space in MB</returns>
    public static decimal GetFreeSpace(char driveLetter)
    {

        decimal finalDriveSpace = 0;


        
        return finalDriveSpace;
    }

#endregion

#region Text Functions...
    
    /// <summary>
    /// Build source url for media player to stream content
    /// </summary>
    /// <param name="filePath">Path of file to stream</param>
    /// <returns>string representing url of content</returns>
    public static string BuildMediaStreamingUrl(string filePath)
        {

            string baseUrl = @"http://www.jimmysietsma.com/media/tv";
            char showDrive = filePath[0];
            string showName = filePath.Split('\\')[2];
            string showSeason = filePath.Split('\\')[3];
            string showEpisode = filePath.Split('\\')[4];

            return $"{ baseUrl }/{ showDrive }/TV Shows/{ showName }/{ showSeason }/{ showEpisode }";
        }

        /// <summary>
        /// Build list of urls for media player to stream
        /// </summary>
        /// <param name="episodePaths">List of string paths containing episodes</param>
        /// <returns>List of strings containing urls for streaming</returns>
        public static List<string> BuildMediaStreamingUrl(List<string> episodePaths)
        {
            List<string> finalUrls = new List<string>();

            foreach (string filePath in episodePaths)
            {

                finalUrls.Add(BuildMediaStreamingUrl(filePath));

            }


            return finalUrls;
        }

#endregion
        //next set of functions

    }
}
