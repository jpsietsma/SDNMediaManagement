using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.Exceptions
{
    /// <summary>
    /// Occurs when automation detects a media type other than a video in the sort drive
    /// </summary>
    public class InvalidSortFileTypeException : Exception
    {
        /// <summary>
        /// Occurs when automation detects a media type other than a video in the sort drive
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public InvalidSortFileTypeException(string message) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when automation is unable to determine media type from file name
    /// </summary>
    public class InvalidSortNameException : Exception
    {
        /// <summary>
        /// Occurs when automation is unable to determine media type from file name
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public InvalidSortNameException(string message = null) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when automation detects two media files of the same episode in the sort folder
    /// </summary>
    public class DuplicateSortFileException : Exception
    {
        /// <summary>
        /// Occurs when automation detects two media files of the same episode in the sort folder
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public DuplicateSortFileException(string message = null) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when automation gets a request to move a media file to a non-existant path
    /// </summary>
    public class InvalidSortMoveDestinationException : Exception
    {
        /// <summary>
        /// Occurs when automation gets a request to move a media file to a non-existant path
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public InvalidSortMoveDestinationException(string message = null) : base(message: message)
        {
            message += "";
        }
    }

    /// <summary>
    /// Occurs when automation can't move a file due to insufficient space on the destination drive 
    /// </summary>
    public class InsufficientSortMoveDestinationSpaceException : Exception
    {
        /// <summary>
        /// Occurs when automation can't move a file due to insufficient space on the destination drive 
        /// </summary>
        /// <param name="message">Optional additional message text</param>
        public InsufficientSortMoveDestinationSpaceException(string message) : base(message: message)
        {
            message += "";
        }
    }
}
