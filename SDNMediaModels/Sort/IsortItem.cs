using System;
using System.Collections.Generic;
using SDNMediaModels.Feedback;
using SDNMediaModels.List;
using SDNMediaModels.Logs;
using SDNMediaModels.Movie;
using SDNMediaModels.Television;

namespace SDNMediaModels.Sort
{
    public interface IsortItem
    {
        int dlFileExists { get; set; }
        DownloadQueue DownloadQueue { get; set; }
        DateTime fileAdded { get; set; }
        DateTime fileModified { get; set; }
        ICollection<FileMoveHistory> FileMoveHistories { get; set; }
        string fileName { get; set; }
        string fileNameSanitized { get; set; }
        string filePath { get; set; }
        string finalizedFileName { get; set; }
        string finalizedFilePath { get; set; }
        string finalizedShowEpisode { get; set; }
        string finalizedShowName { get; set; }
        string finalizedShowSeason { get; set; }
        int finalizedStatus { get; set; }
        int fk_automationStatus { get; set; }
        int fk_fileMediaTypeID { get; set; }
        string fk_torrentID { get; set; }
        int hasBeenDistributed { get; set; }
        int hasBeenFinalized { get; set; }
        int hasBeenProcessed { get; set; }
        int hasBeenSanitized { get; set; }
        list_AutomationStatuses list_AutomationStatuses { get; set; }
        list_MediaTypes list_MediaTypes { get; set; }
        ICollection<Movie.Movie> Movies { get; set; }
        int pk_MediaID { get; set; }
        ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
    }
}