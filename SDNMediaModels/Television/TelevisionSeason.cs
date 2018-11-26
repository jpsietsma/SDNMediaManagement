using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDNMediaModels.Television
{    
    
    public partial class TelevisionSeason : ITelevisionSeason
    {

        public TelevisionSeason()
        {
            this.PlaybackHistories = new HashSet<PlaybackHistory>();
            this.TelevisionEpisodes = new HashSet<TelevisionEpisode>();
            this.UserRequests = new HashSet<UserRequest>();

            if (!string.IsNullOrEmpty(this.SeasonName))
            {
                try
                {
                    int.TryParse(this.SeasonName.Split(' ')[1], out int stringNum);
                    this.SeasonNum = stringNum;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message); 
                }

                
            }
        }
        
        [Display(Name = "Season ID")]
        public int pk_SeasonID { get; set; }

        [Display(Name = "Show ID")]
        public int fk_ShowID { get; set; }

        [Display(Name = "Season Name")]
        public string SeasonName { get; private set; }

        [NotMapped]
        public int SeasonNum { get; set; }


        [Display(Name = "Season Path")]
        public string SeasonHomePath { get; set; }

        [Display(Name = "# Episodes")]
        public int SeasonNumEpisodes { get; set; }

        public string SeasonAlbumArtPath { get; set; }

        [Display(Name = "Season Enabled?")]
        public bool IsEnabled { get; set; }
    
        public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; }    
        public virtual ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        public virtual ICollection<UserRequest> UserRequests { get; set; }
        public virtual TelevisionShow TelevisionShow { get; set; }
    }
}
