namespace SDNMediaModels.Api
{
    public interface IEztvSeriesResultModel
    {
        string added { get; set; }
        string airsDayOfWeek { get; set; }
        string[] aliases { get; set; }
        string banner { get; set; }
        string firstAired { get; set; }
        string genre { get; set; }
        int id { get; set; }
        string imdbId { get; set; }
        int lastUpdated { get; set; }
        string network { get; set; }
        string networkId { get; set; }
        string overview { get; set; }
        string rating { get; set; }
        string runtime { get; set; }
        string seriesId { get; set; }
        string seriesName { get; set; }
        int siteRating { get; set; }
        int siteRatingCount { get; set; }
        string slug { get; set; }
        string status { get; set; }
        string zap2itId { get; set; }
    }
}