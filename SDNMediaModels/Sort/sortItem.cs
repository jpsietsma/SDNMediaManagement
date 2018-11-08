using SDNMediaModels.Feedback;
using SDNMediaModels.List;
using SDNMediaModels.Logs;
using SDNMediaModels.Movies;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Sort
{   
    
    public partial class sortItem
    {

        public sortItem()
        {
            this.FileMoveHistories = new HashSet<FileMoveHistory>();
            this.Movies = new HashSet<Movie>();
            this.TelevisionEpisodes = new HashSet<TelevisionEpisode>();
        }
    
        public int pk_MediaID { get; set; }
        public string filePath { get; set; }
        public string fileName { get; set; }
        public int hasBeenSanitized { get; set; }
        public string fileNameSanitized { get; set; }
        public int hasBeenProcessed { get; set; }
        public System.DateTime fileModified { get; set; }
        public System.DateTime fileAdded { get; set; }
        public int fk_fileMediaTypeID { get; set; }
        public int fk_automationStatus { get; set; }
        public string finalizedFilePath { get; set; }
        public string finalizedFileName { get; set; }
        public string finalizedShowName { get; set; }
        public string finalizedShowSeason { get; set; }
        public string finalizedShowEpisode { get; set; }
        public int hasBeenFinalized { get; set; }
        public int hasBeenDistributed { get; set; }
        public int dlFileExists { get; set; }
        public int finalizedStatus { get; set; }
        public string fk_torrentID { get; set; }
    
        public virtual DownloadQueue DownloadQueue { get; set; }
        public virtual ICollection<FileMoveHistory> FileMoveHistories { get; set; }
        public virtual list_AutomationStatuses list_AutomationStatuses { get; set; }
        public virtual list_MediaTypes list_MediaTypes { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
    }
}
