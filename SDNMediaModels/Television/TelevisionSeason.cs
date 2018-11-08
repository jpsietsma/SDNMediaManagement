using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Television
{    
    
    public partial class TelevisionSeason : ITelevisionSeason
    {

        public TelevisionSeason()
        {
            this.PlaybackHistories = new HashSet<PlaybackHistory>();
            this.TelevisionEpisodes = new HashSet<TelevisionEpisode>();
            this.UserRequests = new HashSet<UserRequest>();
        }
    
        public int pk_SeasonID { get; set; }
        public int fk_ShowID { get; set; }
        public string SeasonName { get; set; }
        public string SeasonHomePath { get; set; }
        public int SeasonNumEpisodes { get; set; }
        public string SeasonAlbumArtPath { get; set; }
        public bool IsEnabled { get; set; }
    
        public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; }    
        public virtual ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
        public virtual TelevisionShow TelevisionShow { get; set; }
    }
}
