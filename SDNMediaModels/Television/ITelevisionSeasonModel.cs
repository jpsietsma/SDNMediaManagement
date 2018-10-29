namespace SDNMediaModels.Television
{
    public interface ITelevisionSeasonModel
    {
        int fk_ShowID { get; set; }
        int IsEnabled { get; set; }
        int pk_SeasonID { get; set; }
        string SeasonHomePath { get; set; }
        string SeasonName { get; set; }
        int SeasonNumEpisodes { get; set; }
        string ShowName { get; set; }
    }
}