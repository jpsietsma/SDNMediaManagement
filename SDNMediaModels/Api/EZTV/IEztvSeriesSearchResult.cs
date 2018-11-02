namespace SDNMediaModels.Api
{
    public interface IEztvSeriesSearchResult
    {
        string[] aliases { get; set; }
        string banner { get; set; }
        bool ExistingShow { get; set; }
        string firstAired { get; set; }
        int id { get; set; }
        string network { get; set; }
        string overview { get; set; }
        string seriesName { get; set; }
        string slug { get; set; }
        string status { get; set; }
    }
}