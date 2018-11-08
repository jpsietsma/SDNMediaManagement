using SDNMediaModels.Sort;
using System;
using System.Collections.Generic;
	
namespace SDNMediaModels.Feedback
{    
    
    public partial class DownloadQueue : IDownloadQueue
    {

        public DownloadQueue()
        {
            this.sortItems = new HashSet<sortItem>();
        }
    
        public string pk_torrentID { get; set; }
        public string TorrentName { get; set; }
        public Nullable<System.DateTime> DownloadFinished { get; set; }
        public Nullable<System.DateTime> DownloadStarted { get; set; }
        public string TorrentStatus { get; set; }
        public string TorrentPath { get; set; }
        public Nullable<int> DownloadDuration { get; set; }
        public int fileSize { get; set; }
    
        public virtual ICollection<sortItem> sortItems { get; set; }
    }
}
