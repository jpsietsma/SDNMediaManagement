
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>


namespace SDNMediaModels.StoredProcedure
{
    using System;
    
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
