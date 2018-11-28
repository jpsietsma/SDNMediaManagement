using SDNMediaModels.Api;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.Television
{  
    /// <summary>
    /// Class to hold Television Show data
    /// </summary>
    public partial class TelevisionShow : ITelevisionShow
    {

        /// <summary>
        /// Constructor to create TelevisionShow object
        /// </summary>
        public TelevisionShow()
        {

            this.PlaybackHistories = new HashSet<PlaybackHistory>();
            this.TelevisionEpisodes = new HashSet<TelevisionEpisode>();
            this.TelevisionSeasons = new HashSet<TelevisionSeason>();
            this.UserRequests = new HashSet<UserRequest>();
            this.Eztv = string.Empty;

            if (!string.IsNullOrEmpty(this.ImdbID))
            {

            }            

        }

        /// <summary>
        /// SDN Media Manager show Id
        /// </summary>
        public int pk_ShowID { get; set; }

        /// <summary>
        ///  Television Show Name
        /// </summary>
        [Display(Name = "Show Name")]
        public string ShowName { get; set; }
        
        /// <summary>
        /// Drive letter of storage drive where show lives
        /// </summary>
        public string ShowDriveLetter { get; set; }

        /// <summary>
        /// Full local file path to folder where show lives
        /// </summary>
        [Display(Name = "Show Full Path")]
        public string ShowHomePath { get; set; }

        /// <summary>
        /// Number of seasons that exist in media manager for this show
        /// </summary>
        [Display(Name = "# of Seasons")]
        public Nullable<int> ShowNumSeasons { get; set; }

        /// <summary>
        /// Number of episodes that exist in media manager for this show
        /// </summary>
        [Display(Name = "# of Episodes")]
        public Nullable<int> ShowNumEpisodes { get; set; }
        
        /// <summary>
        /// Path to folder that holds meta data and temp files for this show
        /// </summary>
        public string ShowAlbumArtPath { get; set; }

        /// <summary>
        /// True if this show appears in searches within media manager
        /// </summary>
        [Display(Name = "Show Enabled?")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// TVDB Show Id for use in pulling meta data from API
        /// </summary>
        [Display(Name = "TVDB ID")]
        public string TvdbID { get; set; }

        /// <summary>
        /// IMDB Show Id for use in pulling meta data from API
        /// </summary>
        [Display(Name = "IMDB ID")]
        public string ImdbID { get; set; }
        
        /// <summary>
        /// Represents the media type
        /// </summary>
        public Nullable<int> fk_MediaType { get; set; }

        /// <summary>
        /// returns true if model representing show is empty
        /// </summary>
        public bool Empty
        {
            get
            {
                return (pk_ShowID == 0 &&
                        string.IsNullOrWhiteSpace(ShowName) &&
                        string.IsNullOrWhiteSpace(ShowHomePath));
            }
        }

        /// <summary>
        /// User playback history for this show
        /// </summary>
        public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; }

        /// <summary>
        /// Episodes that belong to this show
        /// </summary>
        public virtual ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }

        /// <summary>
        /// Seasons that belong to this show
        /// </summary>
        public virtual ICollection<TelevisionSeason> TelevisionSeasons { get; set; }

        /// <summary>
        /// User requests related to this show
        /// </summary>
        public virtual ICollection<UserRequest> UserRequests { get; set; }

        /// <summary>
        /// Tracked shows
        /// </summary>
        public virtual ICollection<TrackedShow> TrackedShows { get; set; }

        /// <summary>
        /// Eztv downloads for show
        /// </summary>
        public virtual string Eztv { get; set; }



    }
}
