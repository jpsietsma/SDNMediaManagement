using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.Television
{  

    public partial class TelevisionShow : ITelevisionShow
    {
        public TelevisionShow()
        {

            this.PlaybackHistories = new HashSet<PlaybackHistory>();
            this.TelevisionEpisodes = new HashSet<TelevisionEpisode>();
            this.TelevisionSeasons = new HashSet<TelevisionSeason>();
            this.UserRequests = new HashSet<UserRequest>();
        }

        public int pk_ShowID { get; set; }

        [Display(Name = "Show Name")]
        public string ShowName { get; set; }        
        public string ShowDriveLetter { get; set; }

        [Display(Name = "Show Full Path")]
        public string ShowHomePath { get; set; }

        [Display(Name = "# of Seasons")]
        public Nullable<int> ShowNumSeasons { get; set; }

        [Display(Name = "# of Episodes")]
        public Nullable<int> ShowNumEpisodes { get; set; }


        public string ShowAlbumArtPath { get; set; }

        [Display(Name = "Show Enabled?")]
        public bool IsEnabled { get; set; }

        [Display(Name = "TVDB ID")]
        public string TvdbID { get; set; }

        [Display(Name = "IMDB ID")]
        public string ImdbID { get; set; }


        public Nullable<int> fk_MediaType { get; set; }

        public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        public virtual ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        public virtual ICollection<TelevisionSeason> TelevisionSeasons { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
    }
}
