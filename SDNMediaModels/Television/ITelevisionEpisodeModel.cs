namespace SDNMediaModels.Television
{
    public interface ITelevisionEpisodeModel
    {
        string EpisodeAlbumArtPath { get; set; }
        string EpisodeDisplayTitle { get; set; }
        int EpisodeNum { get; set; }
        string EpisodePath { get; set; }
        string EpisodePlayerPath { get; set; }
        int fk_SeasonID { get; set; }
        int fk_ShowID { get; set; }
        int IsEnabled { get; set; }
        int pk_EpisodeID { get; set; }
        string SeasonHomePath { get; set; }
        string SeasonName { get; set; }
        string ShowHomePath { get; set; }
        string ShowName { get; set; }
    }
}