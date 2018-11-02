using System;
using System.Collections.Generic;
using SDNMediaModels.Sort;

namespace SDNMediaModels.Feedback
{
    public interface IDownloadQueue
    {
        int? DownloadDuration { get; set; }
        DateTime? DownloadFinished { get; set; }
        DateTime? DownloadStarted { get; set; }
        int fileSize { get; set; }
        string pk_torrentID { get; set; }
        ICollection<sortItem> sortItems { get; set; }
        string TorrentName { get; set; }
        string TorrentPath { get; set; }
        string TorrentStatus { get; set; }
    }
}