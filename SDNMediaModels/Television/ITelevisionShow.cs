using System;
using System.Collections.Generic;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;

namespace SDNMediaModels.Television
{
    public interface ITelevisionShow
    {
        int? fk_MediaType { get; set; }
        string ImdbID { get; set; }
        bool IsEnabled { get; set; }
        int pk_ShowID { get; set; }        
        string ShowAlbumArtPath { get; set; }
        string ShowDriveLetter { get; set; }
        string ShowHomePath { get; set; }
        string ShowName { get; set; }
        string TvdbID { get; set; }
        Nullable<int> ShowNumEpisodes { get; set; }
        Nullable<int> ShowNumSeasons { get; set; }        
        ICollection<UserRequest> UserRequests { get; set; }
        ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        ICollection<TelevisionSeason> TelevisionSeasons { get; set; }
    }
}