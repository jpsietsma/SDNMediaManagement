using MediaMaintenanceLibrary.enums;
using MediaMaintenanceLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.interfaces
{
    /// <summary>
    /// represents a media file residing in the sort folder, usually undetermined
    /// </summary>
    interface ISortMediaItem
    {
        /// <summary>
        /// Full Path to the media file
        /// </summary>
        string filePath { get; set; }

        /// <summary>
        /// File Name of the media file
        /// </summary>
        string fileName { get; set; }

        /// <summary>
        /// Media File type - Defaults to SORT_ITEM until sanitized and processed.
        /// </summary>
        MediaTypeOptions fileMediaType { get; set; }

        /// <summary>
        /// Convert a SortMediaItemModel
        /// </summary>
        /// <returns>converted TelevisionEpisodeModel object</returns>
        TelevisionEpisodeModel ToEpisode();

        /// <summary>
        /// Convert a SortMediaItemModel
        /// </summary>
        /// <returns>converted MovieModel object</returns>
        MovieModel ToMovie();


    }
}
