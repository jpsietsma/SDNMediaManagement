using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardUI.Models
{
    [Table("EpisodeInfoVw")]
    public class TelevisionEpisodeModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Episode ID")]
        public int pk_EpisodeID { get; set; }

        [Required]
        [Editable(false)]
        [DisplayName("Season Name")]
        public string SeasonName { get; set; }

        [Required]
        [Editable(false)]
        [DisplayName("Episode Path")]
        public string EpisodePath { get; set; }

        [Editable(false)]
        [DisplayName("Cover Path")]
        public string EpisodeAlbumArtPath { get; set; }

        [Editable(false)]
        [DisplayName("Episode Player")]
        public string EpisodePlayerPath { get; set; }

        [Required]
        [Editable(false)]
        [DisplayName("Show Name")]
        public string ShowName { get; set; }

        [Editable(true)]
        [DisplayName("Episode Enabled")]
        public int IsEnabled { get; set; }

        [Required]
        [Editable(false)]
        [DisplayName("Episode Number")]
        public int EpisodeNum { get; set; }

        [Editable(false)]
        [DisplayName("Season Home")]
        public string SeasonHomePath { get; set; }

        [Editable(false)]
        [DisplayName("Show Home")]
        public string ShowHomePath { get; set; }

        [Editable(false)]
        [DisplayName("Season ID")]
        public int fk_SeasonID { get; set; }

        [Editable(false)]
        [DisplayName("Episode Title")]
        public string EpisodeDisplayTitle { get; set; }

        [Editable(false)]
        [DisplayName("Show ID")]
        public int fk_ShowID { get; set; }

        public TelevisionEpisodeModel()
        {

        }

    }
}