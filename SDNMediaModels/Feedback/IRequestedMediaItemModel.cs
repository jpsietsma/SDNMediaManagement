namespace SDNMediaModels.Feedback
{
    public interface IRequestedMediaItemModel
    {
        string ExistingSeries { get; set; }
        int pk_RequestID { get; set; }
        int RequestCompleted { get; set; }
        string RequestEpisode { get; set; }
        string RequestMovie { get; set; }
        string RequestMovieGenre { get; set; }
        string RequestMovieYear { get; set; }
        string RequestQuery { get; set; }
        string RequestSeason { get; set; }
        string RequestShow { get; set; }
        int? RequestSubtype { get; set; }
        int? RequestType { get; set; }
    }
}