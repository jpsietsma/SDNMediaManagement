using Newtonsoft.Json;
using SDNMediaModels.Movies;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaMaintenanceLibrary
{
    /// <summary>
    /// Registers our media extension methods
    /// </summary>
    public static class MediaConversion
    {

#region Sort Model Extension Methods...

        /// <summary>
        /// Convert finalized Sort Item to Television Episode
        /// </summary>
        /// <param name="sortModel">Model to convert to Television Episode</param>
        /// <returns>TelevisionEpisode converted from SortMediaItem</returns>
        public static TelevisionEpisode ToEpisode(this sortItem sortModel)
        {
            TelevisionEpisode newEpisode = new TelevisionEpisode { pk_EpisodeID = sortModel.pk_MediaID, EpisodePath = sortModel.filePath };

            return newEpisode;
        }

        /// <summary>
        /// Convert finalized Sort Item to Movie
        /// </summary>
        /// <param name="sortModel">Model to convert to Movie</param>
        /// <returns>Movy converted from SortMediaItem</returns>
        public static Movie ToMovie(this sortItem sortModel)
        {
            Movie newMovie = new Movie { pk_MovieID = sortModel.pk_MediaID, FileName = sortModel.fileName, FilePath = sortModel.filePath };

            return newMovie;
        }       

#endregion

#region Media Streaming & Playlist Methods...

        /// <summary>
        /// Build source url for media player to stream content
        /// </summary>
        /// <param name="filePath">Path of file to stream</param>
        /// <returns>string representing url of content</returns>
        public static string BuildStreamingUrl(string filePath)
        {

            string baseUrl = @"http://www.jimmysietsma.com/media/tv";
            char showDrive = filePath[0];
            string showName = filePath.Split('\\')[2];
            string showSeason = filePath.Split('\\')[3];
            string showEpisode = filePath.Split('\\')[4];

            return $"{ baseUrl }/{ showDrive }/TV Shows/{ showName }/{ showSeason }/{ showEpisode }";
        }

        /// <summary>
        /// Return or build source url for streaming content
        /// </summary>
        /// <param name="movie">TelevisionEpisode to build streaming url</param>
        /// <returns>string url to pass to web media streaming</returns>
        public static string BuildStreamingUrl(Movie movie)
        {

                string baseUrl = @"http://www.jimmysietsma.com/media/movie";
                char movieDrive = movie.FilePath[0];
                string movieGenre = movie.FilePath.Split('\\')[2];
                string movieTitle = movie.FileName;

                return $"{ baseUrl }/{ movieDrive }/Movies/{ movieGenre }/{ movieTitle }";
                        
        }

        /// <summary>
        /// Return or build source url for streaming content
        /// </summary>
        /// <param name="episode">TelevisionEpisode to build streaming url</param>
        /// <returns>string url to pass to web media streaming</returns>
        public static string BuildStreamingUrl(TelevisionEpisode episode)
        {

            if (string.IsNullOrEmpty(episode.EpisodePlayerPath))
            {
                string baseUrl = @"http://www.jimmysietsma.com/media/tv";
                char showDrive = episode.EpisodePath[0];
                string showName = episode.EpisodePath.Split('\\')[2];
                string showSeason = episode.EpisodePath.Split('\\')[3];
                string showEpisode = episode.EpisodePath.Split('\\')[4];

                return $"{ baseUrl }/{ showDrive }/TV Shows/{ showName }/{ showSeason }/{ showEpisode }";
            }
            else
            {
                return episode.EpisodePlayerPath;
            }

        }

        /// <summary>
        /// Build list of urls for media player to stream
        /// </summary>
        /// <param name="episodeModels">List of string paths containing episodes</param>
        /// <returns>List of strings containing urls for streaming</returns>
        public static List<string> BuildStreamingPlaylist (List<TelevisionEpisode> episodeModels)
        {
            List<string> finalUrls = new List<string>();

            foreach (TelevisionEpisode episode in episodeModels)
            {

                finalUrls.Add(BuildStreamingUrl(episode));

            }


            return finalUrls;
        }

        /// <summary>
        /// Build list of urls for media player to stream
        /// </summary>
        /// <param name="Movys">List of Movie items</param>
        /// <returns>List of strings containing urls for streaming</returns>
        public static List<string> BuildStreamingPlaylist(List<Movie> Movys)
        {
            List<string> finalUrls = new List<string>();

            foreach (Movie movie in Movys)
            {

                finalUrls.Add(BuildStreamingUrl(movie));

            }


            return finalUrls;
        }


        #endregion

    }
}
