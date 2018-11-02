using System.Collections.Generic;
using SDNMediaModels.Feedback;
using SDNMediaModels.List;
using SDNMediaModels.Logs;
using SDNMediaModels.Sort;

namespace SDNMediaModels.Television
{
    public interface ITelevisionEpisode
    {
        string EpisodeAlbumArtPath { get; set; }
        string EpisodeDisplayTitle { get; set; }
        int EpisodeNum { get; set; }
        string EpisodePath { get; set; }
        string EpisodePlayerPath { get; set; }
        int? fk_MediaID { get; set; }
        int? fk_MediaType { get; set; }
        int fk_SeasonID { get; set; }
        int fk_ShowID { get; set; }
        int IsEnabled { get; set; }
        list_MediaTypes list_MediaTypes { get; set; }
        int pk_EpisodeID { get; set; }
        ICollection<PlaybackHistory> PlaybackHistories { get; set; }
        sortItem sortItem { get; set; }
        ITelevisionSeason ITelevisionSeason { get; set; }
        ITelevisionShow ITelevisionShow { get; set; }
        ICollection<UserRequest> UserRequests { get; set; }
    }
}