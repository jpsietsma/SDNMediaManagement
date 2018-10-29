using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SDNMediaModels.Feedback
{
    [Table("sdnRequestedMedia")]
    public class RequestedMediaItemModel : IRequestedMediaItemModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Request ID")]
        public int pk_RequestID { get; set; }

        [Editable(false)]
        [DisplayName("Request Query")]
        public string RequestQuery { get; set; }

        [Editable(false)]
        [DisplayName("Request Type")]
        public int? RequestType { get; set; }

        [Editable(false)]
        [DisplayName("Request Subtype")]
        public int? RequestSubtype { get; set; }

        [Editable(false)]
        [DisplayName("Existing Series")]
        public string ExistingSeries { get; set; }

        [Editable(false)]
        [DisplayName("Request Show")]
        public string RequestShow { get; set; }

        [Editable(false)]
        [DisplayName("Request Season")]
        public string RequestSeason { get; set; }

        [Editable(false)]
        [DisplayName("Request Episode")]
        public string RequestEpisode { get; set; }

        [Editable(false)]
        [DisplayName("Request Movie Title")]
        public string RequestMovie { get; set; }

        [Editable(false)]
        [DisplayName("Movie Year")]
        public string RequestMovieYear { get; set; }

        [Editable(false)]
        [DisplayName("Movie Genre")]
        public string RequestMovieGenre { get; set; }

        [Editable(true)]
        [DisplayName("Request Completed")]
        public int RequestCompleted { get; set; }

        public RequestedMediaItemModel()
        {

        }

    }
}