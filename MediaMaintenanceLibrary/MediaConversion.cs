using Newtonsoft.Json;
using SDNMediaModels.Image;
using SDNMediaModels.Movie;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary
{
    /// <summary>
    /// Registers our media extension methods
    /// </summary>
    public static class MediaConversion
    {

#region Screenshot Gallery Methods...

        /// <summary>
        /// Build Json Array for image gallery sources
        /// </summary>
        /// <param name="files">List of string of file paths</param>
        /// <param name="directory">Directory to filter files</param>
        /// <returns> string representing json array of src and title entries</returns>
        public static string GetJsonArrayImageSrc(IEnumerable<string> files, string directory)
        {
            StringBuilder finalJson = new StringBuilder();
            finalJson.Append(" items: [");

            int i = 0;
            
            foreach (string file in files)
            {
                i++;

                if (file.Contains(directory))
                {
                    string entry = string.Empty;

                    if (i < files.Count())
                    {
                        entry = $"{{ \"src\": \"{ file.Split('\\')[5] }\", \"title\": \"{ file.Split('\\')[5].Split('.')[0] }\" }}, ";
                    }
                    else
                    {
                        entry = $"{{ \"src\": \"{ file.Split('\\')[5] }\", \"title\": \"{ file.Split('\\')[5].Split('.')[0] }\" }}";
                    }

                    finalJson.Append(entry);
                }
                
            }

            finalJson.Append("],");

            return finalJson.ToString();
        }

        /// <summary>
        /// Build Json Array for image gallery sources
        /// </summary>
        /// <param name="images">List of GalleryImageModel objects</param>
        /// <param name="directory">Directory to filter objects</param>
        /// <returns> string representing json array of GalleryImageModel entries</returns>
        public static string GetJsonArrayImageSrc(IEnumerable<IGalleryImageModel> images, string directory)
        {

            StringBuilder finalJson = new StringBuilder();

            foreach (IGalleryImageModel imageModel in images)
            {
                if (imageModel._src.Contains(directory))
                {
                    finalJson.Append(imageModel.GetJsonArrayImageSrc());
                }                
            }

            return finalJson.ToString();                                 
        }

        /// <summary>
        /// Build Json Array for image gallery source
        /// </summary>
        /// <param name="image">GalleryImageModel object</param>
        /// <returns> string representing json array of GalleryImageModel</returns>
        public static string GetJsonArrayImageSrc(this IGalleryImageModel image)
        {
            return JsonConvert.SerializeObject(image);
        }

#endregion


#region Model Conversion Extension Methods...

        /// <summary>
        /// Convert finalized Sort Item to Television Episode
        /// </summary>
        /// <param name="sortModel">Model to convert to Television Episode</param>
        /// <returns>TelevisionEpisodeModel converted from SortMediaItem</returns>
        public static TelevisionEpisodeModel ToEpisode(this SortMediaItemModel sortModel)
        {
            TelevisionEpisodeModel newEpisode = new TelevisionEpisodeModel { pk_EpisodeID = sortModel.pk_MediaID, EpisodePath = sortModel.filePath };

            return newEpisode;
        }

        /// <summary>
        /// Convert finalized Sort Item to Movie
        /// </summary>
        /// <param name="sortModel">Model to convert to Movie</param>
        /// <returns>MovieModel converted from SortMediaItem</returns>
        public static MovieModel ToMovie(this SortMediaItemModel sortModel)
        {
            MovieModel newMovie = new MovieModel { pk_MovieID = sortModel.pk_MediaID, fileName = sortModel.fileName, filePath = sortModel.filePath };

            return newMovie;
        }

        /// <summary>
        /// Convert finalized Sort Item to Screenshot
        /// </summary>
        /// <param name="sortModel">Model to convert to ScreenShot</param>
        /// <returns>GalleryImageModel converted from SortMediaItem</returns>
        public static GalleryImageModel ToScreenshot(this SortMediaItemModel sortModel)
        {
            GalleryImageModel newImage = new GalleryImageModel(sortModel.fileName, sortModel.fileName);

            return newImage;
        }

#endregion

    }
}
