namespace SDNMediaModels.Api
{
    public interface IEztvResult
    {
        int date_released_unix { get; set; }
        string episode { get; set; }
        string episode_url { get; set; }
        string filename { get; set; }
        string hash { get; set; }
        int id { get; set; }
        string imdb_id { get; set; }
        string large_screenshot { get; set; }
        string magnet_url { get; set; }
        int peers { get; set; }
        string season { get; set; }
        int seeds { get; set; }
        string size_bytes { get; set; }
        string small_screenshot { get; set; }
        string title { get; set; }
        string torrent_url { get; set; }

        bool DownloadExists();
        bool EpisodeExists();
        bool ShowExists();
    }
}