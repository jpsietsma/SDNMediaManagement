using System;

namespace SDNMediaModels.StoredProcedure
{
      
    public partial class GetDailyDownloads_Result
    {
        public string pk_torrentID { get; set; }
        public string TorrentName { get; set; }
        public Nullable<System.DateTime> DownloadFinished { get; set; }
        public Nullable<System.DateTime> DownloadStarted { get; set; }
        public string TorrentStatus { get; set; }
        public string TorrentPath { get; set; }
        public Nullable<int> DownloadDuration { get; set; }
        public int fileSize { get; set; }
    }
}
