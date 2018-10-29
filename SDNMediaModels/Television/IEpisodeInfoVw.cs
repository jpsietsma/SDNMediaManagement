namespace SDNMediaModels.Television
{
    public interface IEpisodeInfoVw
    {
        string EpisodePath { get; set; }
        string EpisodePlayerPath { get; set; }
        int fk_ShowID { get; set; }
        int pk_EpisodeID { get; set; }
        string SeasonHomePath { get; set; }
        string SeasonName { get; set; }
        string ShowHomePath { get; set; }
        string ShowName { get; set; }
    }
}