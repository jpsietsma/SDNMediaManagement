using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SDNMediaModels.Television
{
    [Table("EpisodeInfoVw")]
    public class TelevisionEpisodeModel : ITelevisionEpisodeModel
    {
        [Key]
        [DisplayName("Episode ID")]
        public int pk_EpisodeID { get; set; }


        [DisplayName("Season Name")]
        public string SeasonName { get; set; }


        [DisplayName("Episode Path")]
        public string EpisodePath { get; set; }

        [Editable(false)]
        [DisplayName("Cover Path")]
        public string EpisodeAlbumArtPath { get; set; }

        [Editable(false)]
        [DisplayName("Episode Player")]
        public string EpisodePlayerPath { get; set; }


        [DisplayName("Show Name")]
        public string ShowName { get; set; }


        [DisplayName("Episode Enabled")]
        public int IsEnabled { get; set; }


        [DisplayName("Episode Number")]
        public int EpisodeNum { get; set; }


        [DisplayName("Season Home")]
        public string SeasonHomePath { get; set; }


        [DisplayName("Show Home")]
        public string ShowHomePath { get; set; }


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