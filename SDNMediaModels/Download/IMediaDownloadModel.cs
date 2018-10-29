using System;

namespace SDNMediaModels.Download
{
    public interface IMediaDownloadModel
    {
        string automationStatusDisplay { get; set; }
        int? DownloadDuration { get; set; }
        DateTime? DownloadFinished { get; set; }
        DateTime? DownloadStarted { get; set; }
        string fileNameSanitized { get; set; }
        string finalizedShowEpisode { get; set; }
        string finalizedShowName { get; set; }
        string finalizedShowSeason { get; set; }
        int? hasBeenDistributed { get; set; }
        int? hasBeenFinalized { get; set; }
        int? hasBeenProcessed { get; set; }
        int? hasBeenSanitized { get; set; }
        string MediaTypeName { get; set; }
        string MoveDestination { get; set; }
        DateTime? MoveTime { get; set; }
        int? pk_MediaID { get; set; }
        string pk_torrentID { get; set; }
        string TorrentName { get; set; }
        string TorrentPath { get; set; }
        string TorrentStatus { get; set; }
    }
}