using SDNMediaModels.Account;
using SDNMediaModels.List;
using SDNMediaModels.Television;

namespace SDNMediaModels.Feedback
{
    public interface IUserRequest
    {
        AspNetUser AspNetUser { get; set; }
        string ExistingSeries { get; set; }
        int? fk_AutomationStatus { get; set; }
        int? fk_EpisodeID { get; set; }
        int? fk_SeasonID { get; set; }
        int? fk_ShowID { get; set; }
        string fk_UserID { get; set; }
        list_AutomationStatuses list_AutomationStatuses { get; set; }
        int pk_RequestID { get; set; }
        int? RequestCompleted { get; set; }
        string RequestEpisode { get; set; }
        string RequestMovie { get; set; }
        string RequestMovieGenre { get; set; }
        string RequestMovieYear { get; set; }
        string RequestQuery { get; set; }
        string RequestSeason { get; set; }
        string RequestShow { get; set; }
        int? RequestSubtype { get; set; }
        int? RequestType { get; set; }
        TelevisionEpisode TelevisionEpisode { get; set; }
        TelevisionSeason TelevisionSeason { get; set; }
        TelevisionShow TelevisionShow { get; set; }
    }
}