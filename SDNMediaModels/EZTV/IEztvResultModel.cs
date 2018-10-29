namespace SDNMediaModels.EZTV
{
    public interface IEztvResultModel
    {
        int Episode { get; set; }
        string EpisodeUrl { get; set; }
        int EztvID { get; set; }
        string FileName { get; set; }
        string Hash { get; set; }
        int ImdbId { get; set; }
        string LargeScreenshot { get; set; }
        string MagnetUrl { get; set; }
        int Peers { get; set; }
        int ReleaseDateEpoc { get; set; }
        int Season { get; set; }
        int Seeds { get; set; }
        int SizeBytes { get; set; }
        string SmallScreenshot { get; set; }
        string Title { get; set; }
        string TorrentUrl { get; set; }

        bool DownloadExists();
        bool EpisodeExists();
        bool ShowExists();
    }
}