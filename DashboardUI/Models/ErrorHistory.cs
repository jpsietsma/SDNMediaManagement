namespace DashboardUI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErrorHistory")]
    public partial class ErrorHistory
    {
        [Key]
        public int pk_errorID { get; set; }

        [Required]
        public string errorMessage { get; set; }

        public int errorThread { get; set; }

        [Required]
        public string errorExceptionMessage { get; set; }

        [Required]
        public string errorExceptionInner { get; set; }

        [Required]
        [StringLength(10)]
        public string errorType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime errorTimestamp { get; set; }
    }
}
