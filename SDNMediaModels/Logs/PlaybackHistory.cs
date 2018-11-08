using SDNMediaModels.Account;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Logs
{
       
    public partial class PlaybackHistory : IPlaybackHistory
    {
        public int pk_PlaybackID { get; set; }
        public System.DateTime PlaybackDate { get; set; }
        public string fk_UserID { get; set; }
        public int PlaybackProgressStopped { get; set; }
        public int fk_EpisodeID { get; set; }
        public int fk_ShowID { get; set; }
        public int fk_SeasonID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual TelevisionEpisode TelevisionEpisode { get; set; }
        public virtual TelevisionSeason TelevisionSeason { get; set; }
        public virtual TelevisionShow TelevisionShow { get; set; }
    }
}
