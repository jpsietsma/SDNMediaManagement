using SDNMediaModels.Account;
using SDNMediaModels.List;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Feedback
{
        
    public partial class UserRequest : IUserRequest
    {
        public int pk_RequestID { get; set; }
        public Nullable<int> RequestType { get; set; }
        public Nullable<int> RequestSubtype { get; set; }
        public string ExistingSeries { get; set; }
        public string RequestQuery { get; set; }
        public string RequestShow { get; set; }
        public string RequestSeason { get; set; }
        public string RequestEpisode { get; set; }
        public string RequestMovie { get; set; }
        public string RequestMovieYear { get; set; }
        public string RequestMovieGenre { get; set; }
        public Nullable<int> RequestCompleted { get; set; }
        public Nullable<int> fk_ShowID { get; set; }
        public Nullable<int> fk_EpisodeID { get; set; }
        public Nullable<int> fk_SeasonID { get; set; }
        public string fk_UserID { get; set; }
        public Nullable<int> fk_AutomationStatus { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual list_AutomationStatuses list_AutomationStatuses { get; set; }
        public virtual TelevisionEpisode TelevisionEpisode { get; set; }
        public virtual TelevisionSeason TelevisionSeason { get; set; }
        public virtual TelevisionShow TelevisionShow { get; set; }
    }
}
