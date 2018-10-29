using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDNMediaModels.Image
{

    /// <summary>
    /// Class representing images in a screenshot gallery
    /// </summary>
    public class GalleryImageModel : IGalleryImageModel
    {
        /// <summary>
        /// Image filename
        /// </summary>
        public string _src { get; set; }

        /// <summary>
        /// Thumbnail Text
        /// </summary>
        public string _title { get; set; }

        /// <summary>
        /// Represents a game screenshot image
        /// </summary>
        /// <param name="src">Image filename</param>
        /// <param name="title">Thumbnail Text</param>
        public GalleryImageModel(string src, string title)
        {
            _src = src;
            _title = title;
        }

        /// <summary>
        /// Convert this object to a serialized JSON array
        /// </summary>
        /// <returns>Serialized json string of object</returns>
        public string ConvertJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
