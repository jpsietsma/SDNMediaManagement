
namespace SDNMediaModels.enums
{
    /// <summary>
    /// Copy status of Media File
    /// </summary>
    public enum FileCopyStatus
    {
        /// <summary>
        /// Waiting to Copy
        /// </summary>
        COPY_QUEUED,

        /// <summary>
        /// File Copying
        /// </summary>
        COPYING,

        /// <summary>
        /// File Copy Paused
        /// </summary>
        COPY_PAUSED,

        /// <summary>
        /// File Copy Complete
        /// </summary>
        COPY_COMPLETE

    }
}
