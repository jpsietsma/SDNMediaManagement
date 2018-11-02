using System.Collections.Generic;
using SDNMediaModels.Feedback;
using SDNMediaModels.Logs;

namespace SDNMediaModels.Television
{
    public interface ITelevisionSeason
    {
        int fk_ShowID { get; set; }
        int IsEnabled { get; set; }
        int pk_SeasonID { get; set; }
        ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        string SeasonAlbumArtPath { get; set; }
        string SeasonHomePath { get; set; }
        string SeasonName { get; set; }
        int SeasonNumEpisodes { get; set; }
        ICollection<TelevisionEpisode> TelevisionEpisodes { get; set; }
        TelevisionShow TelevisionShow { get; set; }
        ICollection<UserRequest> UserRequests { get; set; }
    }
}