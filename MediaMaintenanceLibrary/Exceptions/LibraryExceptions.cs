using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.Exceptions
{
    /// <summary>
    /// Occurs when a file is missing when its reported as being downloaded
    /// </summary>
    public class LibraryFileMissingException : Exception
    {
        /// <summary>
        /// /// Occurs when a file is missing when its reported as being downloaded
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public LibraryFileMissingException(string message) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when the library maintenance automation is unable to move an episode due to insufficient space
    /// </summary>
    public class LibraryInsufficientEpisodeSpaceException : Exception
    {
        /// <summary>
        /// Occurs when the library maintenance automation is unable to move an episode due to insufficient space
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public LibraryInsufficientEpisodeSpaceException(string message) : base(message: message)
        {
            message += "";
        }
    }

    
    
}
