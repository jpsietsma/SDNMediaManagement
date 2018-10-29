using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.Television
{    
    [Table("EpisodeInfoVw")]
    public partial class EpisodeInfoVw : IEpisodeInfoVw
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pk_EpisodeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fk_ShowID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string EpisodePath { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string EpisodePlayerPath { get; set; }

        [StringLength(15)]
        public string SeasonName { get; set; }

        [StringLength(100)]
        public string SeasonHomePath { get; set; }

        [StringLength(75)]
        public string ShowName { get; set; }

        [StringLength(50)]
        public string ShowHomePath { get; set; }
    }
}
