using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.Exceptions
{
    /// <summary>
    /// Occurs when maintenance discovers a missing television show season
    /// </summary>
    public class MaintenanceMissingSeasonException : Exception
    {
        /// <summary>
        /// Occurs when maintenance discovers a missing television show season
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public MaintenanceMissingSeasonException(string message) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when maintenance discovers a file with a banned file type
    /// </summary>
    public class MaintenanceDisallowedFileTypeException : Exception
    {
        /// <summary>
        /// Occurs when maintenance discovers a file with a banned file type
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public MaintenanceDisallowedFileTypeException(string message) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when maintenance discovers a missing library episode
    /// </summary>
    public class MaintenanceMissingEpisodeException : Exception
    {
        /// <summary>
        /// Occurs when maintenance discovers a missing library episode
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public MaintenanceMissingEpisodeException(string message) : base(message: message)
        {
            message += "";
        }
    }

}
