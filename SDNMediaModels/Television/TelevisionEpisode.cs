using SDNMediaModels.Feedback;
using SDNMediaModels.List;
using SDNMediaModels.Logs;
using SDNMediaModels.Sort;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Television
{   
    
    public partial class TelevisionEpisode : ITelevisionEpisode
    {

        public TelevisionEpisode()
        {
            this.PlaybackHistories = new HashSet<PlaybackHistory>();
            this.UserRequests = new HashSet<UserRequest>();
        }
    
        public int pk_EpisodeID { get; set; }
        public int fk_SeasonID { get; set; }
        public int fk_ShowID { get; set; }
        public int EpisodeNum { get; set; }
        public string EpisodePath { get; set; }
        public string EpisodePlayerPath { get; set; }
        public string EpisodeDisplayTitle { get; set; }
        public string EpisodeAlbumArtPath { get; set; }
        public int IsEnabled { get; set; }
        public Nullable<int> fk_MediaID { get; set; }
        public Nullable<int> fk_MediaType { get; set; }
    
        public virtual list_MediaTypes list_MediaTypes { get; set; }
        public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        public virtual sortItem sortItem { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
        public virtual TelevisionSeason TelevisionSeason { get; set; }
        public virtual TelevisionShow TelevisionShow { get; set; }
    }
}
