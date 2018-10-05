using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DashboardUI.Models
{
    [Table("sdnTelevisionShows")]
    public class TelevisionShowModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Show ID")]
        public int pk_ShowID { get; set; }

        [Editable(false)]
        [DisplayName("Show Name")]
        public string ShowName { get; set; }

        [Editable(false)]
        [DisplayName("Show Drive")]
        public string ShowDriveLetter { get; set; }

        [DisplayName("Show Home")]
        public string ShowHomePath { get; set; }

        [Editable(false)]
        [DisplayName("# of Seasons")]
        public int ShowNumSeasons { get; set; }

        [Editable(false)]
        [DisplayName("# of Episodes")]
        public int ShowNumEpisodes { get; set; }

        [Editable(true)]
        [DisplayName("Show Enabled")]
        public int IsEnabled { get; set; }

        public TelevisionShowModel()
        {

        }

        public virtual List<TelevisionEpisodeModel> Episodes { get; set; }
        public virtual List<TelevisionSeasonModel> Seasons { get; set; }

    }
}