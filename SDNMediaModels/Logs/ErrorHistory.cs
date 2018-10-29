using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.Logs
{
    
    [Table("ErrorHistory")]
    public partial class ErrorHistory : IErrorHistory
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
