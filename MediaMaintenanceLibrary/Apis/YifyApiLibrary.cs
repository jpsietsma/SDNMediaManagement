using SDNMediaModels.Api.YIFY;
using SDNMediaModels.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.Apis
{

    /// <summary>
    /// Class to access Movie info via the YIFY (YTS.AM) API
    /// </summary>
    public static class YifyApiLibrary
    {

        /// <summary>
        /// Base URL for listing movies
        /// </summary>
        public static string movieListUrl = @"https://yts.am/api/v2/list_movies.json";

        /// <summary>
        /// Base URL for getting Movie details
        /// </summary>
        public static string movieDetailsUrl = @"https://yts.am/api/v2/movie_details.json";

        /// <summary>
        /// Get Movie Details
        /// </summary>
        /// <param name="movieID">YIFY Movie ID</param>
        /// <param name="withImages">bool include images in request response</param>
        /// <param name="withCast">bool include cast info in request response</param>
        /// <returns>Json response to request for Movie details</returns>
        public static string GetYIFYDetails(int movieID, bool withImages = true, bool withCast = true)
        {
            string finalJson = string.Empty;

            string url = movieDetailsUrl + $@"?movie_id={ movieID }&with_images={ withImages }&with_cast={ withCast }";



            return finalJson;
        }

        /// <summary>
        /// Get Movie Details
        /// </summary>
        /// <param name="model">YIFYMovieResult model to get details</param>
        /// <param name="withImages">bool include images in request response</param>
        /// <param name="withCast">bool include cast info in request response</param>
        /// <returns>Json response to request for Movie details</returns>
        public static string GetYIFYDetails(this YIFYMovieResult model, bool withImages = true, bool withCast = true)
        {
            string finalJson = string.Empty;

            string url = movieDetailsUrl + $@"?movie_id={ model.Id }&with_images={ withImages }&with_cast={ withCast }";



            return finalJson;
        }


        /// <summary>
        /// Get the most recent YIFY downloads
        /// </summary>
        /// <returns>List of YIFYMovieResult movies</returns>
        public static List<YIFYMovieResult> GetYIFYMovies()
        {
            List<YIFYMovieResult> downloads = new List<YIFYMovieResult>();




            return downloads;
        }


    }
}
