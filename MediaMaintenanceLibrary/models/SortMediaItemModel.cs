using MediaMaintenanceLibrary.enums;
using MediaMaintenanceLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MediaMaintenanceLibrary.models
{
    [Table("sortItems")]
    public class SortMediaItemModel : ISortMediaItem, IBaseMediaItem
    {
        [Key]
        [Editable(false)]
        [DisplayName("Media ID")]
        public int pk_MediaID { get; set; }

        [Editable(false)]
        [DisplayName("File Path")]
        public string filePath { get; set; }

        [Editable(false)]
        [DisplayName("File Name")]
        public string fileName { get; set; }

        [DisplayName("Sanitized Name")]
        public string fileNameSanitized { get; set; }

        [Editable(false)]
        [DisplayName("Media Type")]
        public int fk_fileMediaTypeID { get; set; }

        [Editable(false)]
        [DisplayName("Date Added")]
        public DateTime fileAdded { get; set; }

        [Editable(false)]
        [DisplayName("Date Modified")]
        public DateTime fileModified { get; set; }

        [Editable(false)]
        [DisplayName("Processed?")]
        public int hasBeenProcessed { get; set; }

        [DisplayName("Sanitized?")]
        public int hasBeenSanitized { get; set; }

        public MediaTypeOptions fileMediaType { get; set; }

        public SortMediaItemModel()
        {
            fileMediaType = MediaTypeOptions.SORT_ITEM;
            int.TryParse(fileMediaType.ToString(), out int i);
            fk_fileMediaTypeID = i;
        }

        public string PopulateFileName(string filePath)
        {
            return filePath.Split('\\').Last();
        }

        public TelevisionEpisodeModel ToEpisode()
        {
            TelevisionEpisodeModel newEpisode = new TelevisionEpisodeModel { pk_EpisodeID = pk_MediaID, EpisodePath = filePath, fileMediaType = MediaTypeOptions.TV_EPISODE };

            return newEpisode;
        }

        public MovieModel ToMovie()
        {
            MovieModel newMovie = new MovieModel { pk_MovieID = pk_MediaID, fileName = fileName, filePath = filePath, fileMediaType = MediaTypeOptions.MOVIE };

            return newMovie;
        }

    }
}