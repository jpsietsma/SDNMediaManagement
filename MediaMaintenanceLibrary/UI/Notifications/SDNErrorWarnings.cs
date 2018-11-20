using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.UI.Notifications
{

    /// <summary>
    /// Exception Class for displaying and logging errors and warnings in the UI
    /// </summary>
    [Serializable]
    public class SDNMediaLibraryPathDoesntExistException : Exception
    {

        /// <summary>
        /// Defined media library path does not exist on target filesystem
        /// </summary>
        public SDNMediaLibraryPathDoesntExistException()
        {

        }


    }
}
