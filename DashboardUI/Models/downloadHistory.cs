namespace DashboardUI.Areas.LogsDashboard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("downloadHistory")]
    public partial class downloadHistory
    {
        [Key]
        public int pk_downloadID { get; set; }

        [Required]
        [StringLength(200)]
        public string filePath { get; set; }

        [Required]
        [StringLength(100)]
        public string fileName { get; set; }

        [Required]
        [StringLength(50)]
        public string fileMediaType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fileCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fileCompleted { get; set; }

        public int pendingSortProcessing { get; set; }

        public downloadHistory(string id)
        {
            this.filePath = id;
        }
    }
}
