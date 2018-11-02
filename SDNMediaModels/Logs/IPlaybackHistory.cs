using System;
using SDNMediaModels.Account;
using SDNMediaModels.Television;

namespace SDNMediaModels.Logs
{
    public interface IPlaybackHistory
    {
        AspNetUser AspNetUser { get; set; }
        int fk_EpisodeID { get; set; }
        int fk_SeasonID { get; set; }
        int fk_ShowID { get; set; }
        string fk_UserID { get; set; }
        int pk_PlaybackID { get; set; }
        DateTime PlaybackDate { get; set; }
        int PlaybackProgressStopped { get; set; }
        TelevisionEpisode TelevisionEpisode { get; set; }
        TelevisionSeason TelevisionSeason { get; set; }
        TelevisionShow TelevisionShow { get; set; }
    }
}