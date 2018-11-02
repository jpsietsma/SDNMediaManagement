
namespace SDNMediaModels.enums
{
    /// <summary>
    /// Airing status of the show
    /// </summary>
    public enum ShowAiringStatus
    {
        /// <summary>
        /// Show is actively airing new episodes
        /// </summary>
        ACTIVE,

        /// <summary>
        /// Waiting confirmation if show will be renewed
        /// </summary>
        PENDING,

        /// <summary>
        /// Show has stopped airing new episodes
        /// </summary>
        ENDED

    }
}
