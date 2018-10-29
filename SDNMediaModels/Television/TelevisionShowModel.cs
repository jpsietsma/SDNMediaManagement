using SDNMediaModels.enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SDNMediaModels.Television
{
    [Table("sdnTelevisionShows")]
    public class TelevisionShowModel : ITelevisionShowModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Show ID")]
        public int pk_ShowID { get; set; }

        [DisplayName("Show Name")]
        public string ShowName { get; set; }

        [DisplayName("Show Drive")]
        public string ShowDriveLetter { get; set; }

        [DisplayName("Show Home")]
        public string ShowHomePath { get; set; }

        [DisplayName("# of Seasons")]
        public int ShowNumSeasons { get; set; }

        [DisplayName("# of Episodes")]
        public int ShowNumEpisodes { get; set; }

        [DisplayName("Show Enabled")]
        public int IsEnabled { get; set; }

        /// <summary>
        /// List of Television Seasons belonging to the show
        /// </summary>
        public DbSet<ITelevisionShowModel> sdnTelevisionShows { get; set; }

        /// <summary>
        /// List of Television Episodes belonging to the show
        /// </summary>
        public DbSet<ITelevisionEpisodeModel> sdnTelevisionEpisodes { get; set; }

        public TelevisionShowModel()
        {


        }
    }
}