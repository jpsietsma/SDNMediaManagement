using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SDNMediaModels.Download
{
    [Table("DownloadInfoVw")]
    public class MediaDownloadModel : IMediaDownloadModel
    {
        [Key]
        [Editable(false)]
        [DisplayName("Torrent ID")]
        public string pk_torrentID { get; set; }

        [Editable(false)]
        [DisplayName("Torrent Name")]
        public string TorrentName { get; set; }

        [Editable(false)]
        [DisplayName("Download Started")]
        public DateTime? DownloadStarted { get; set; }

        [DisplayName("Download Finished")]
        public DateTime? DownloadFinished { get; set; }

        [Editable(false)]
        [DisplayName("Download Status")]
        public string TorrentStatus { get; set; }

        [Editable(false)]
        [DisplayName("File Path")]
        public string TorrentPath { get; set; }

        [Editable(false)]
        [DisplayName("Duration")]
        public int?  DownloadDuration { get; set; }

        [Editable(false)]
        [DisplayName("Show Name")]
        public string finalizedShowName { get; set; }

        [Editable(false)]
        [DisplayName("Show Season")]
        public string finalizedShowSeason { get; set; }

        [Editable(false)]
        [DisplayName("Show Episode")]
        public string finalizedShowEpisode { get; set; }

        [Editable(false)]
        [DisplayName("Sanitized Name")]
        public string fileNameSanitized { get; set; }

        [Editable(false)]
        [DisplayName("Automation Status")]
        public string automationStatusDisplay { get; set; }

        [Editable(false)]
        [DisplayName("Finalized Status")]
        public int? hasBeenFinalized { get; set; }

        [Editable(false)]
        [DisplayName("Distributed Status")]
        public int? hasBeenDistributed { get; set; }

        [Editable(false)]
        [DisplayName("Processed Status")]
        public int? hasBeenProcessed { get; set; }

        [Editable(false)]
        [DisplayName("Sanitized Status")]
        public int? hasBeenSanitized { get; set; }

        [Editable(false)]
        [DisplayName("Sort Media ID")]
        public int? pk_MediaID { get; set; }

        [Editable(false)]
        [DisplayName("Media Type")]
        public string MediaTypeName { get; set; }

        [Editable(false)]
        [DisplayName("Sort Move Destination")]
        public string MoveDestination { get; set; }

        [Editable(false)]
        [DisplayName("Sort Move Time")]
        public DateTime? MoveTime { get; set; }

        public MediaDownloadModel()
        {

        }

    }
}