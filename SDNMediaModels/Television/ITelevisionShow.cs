using System.Collections.Generic;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;

namespace SDNMediaModels.Television
{
    public interface ITelevisionShow
    {
        int? fk_MediaType { get; set; }
        string ImdbID { get; set; }
        int IsEnabled { get; set; }
        int pk_ShowID { get; set; }
        ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        string ShowAlbumArtPath { get; set; }
        string ShowDriveLetter { get; set; }
        string ShowHomePath { get; set; }
        string ShowName { get; set; }
        int ShowNumEpisodes { get; set; }
        int ShowNumSeasons { get; set; }
        ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        ICollection<TelevisionSeason> TelevisionSeasons { get; set; }
        string TvdbID { get; set; }
        ICollection<UserRequest> UserRequests { get; set; }
    }
}