
namespace SDNMediaModels.enums
{
    //Show airing status
    /// <summary>
    /// Reflects whether the show is still actively airing new episodes or has ended
    /// </summary>
    public enum ShowAiringStatus
    {
        /// <summary>
        /// Show is still airing new episodes
        /// </summary>
        ACTIVE = 0,

        /// <summary>
        /// Show is no longer airing new episodes
        /// </summary>
        ENDED = 1,

        /// <summary>
        /// Show previously ended, but has now begun airing new episodes again as the same series
        /// </summary>
        REBOOT = 2,

        /// <summary>
        /// Unknown/Unsure if the show is or will be airing new episodes.  Pending shows should be marked as other.
        /// </summary>
        OTHER = 3

    }
}
