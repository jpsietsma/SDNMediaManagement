using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SDNMediaModels.Television
{
    [Table("SeasonInfoVw")]
    public class TelevisionSeasonModel : ITelevisionSeasonModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Season ID")]
        public int pk_SeasonID { get; set; }

        [Editable(false)]
        [DisplayName("Season Name")]
        public string SeasonName { get; set; }

        [Editable(false)]
        [DisplayName("Season Home")]
        public string SeasonHomePath { get; set; }

        [DisplayName("# of Episodes")]
        public int SeasonNumEpisodes { get; set; }

        [Editable(false)]
        [DisplayName("Show ID")]
        public int fk_ShowID { get; set; }

        [Editable(true)]
        [DisplayName("SDN Enabled")]
        public int IsEnabled { get; set; }

        [Editable(false)]
        [DisplayName("Show Name")]
        public string ShowName { get; set; }

        public DbSet<TelevisionEpisodeModel> sdnTelevisionEpisodes { get; set; }

        public TelevisionSeasonModel()
        {

        }
    }
}