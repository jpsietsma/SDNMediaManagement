using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.Config
{
    /// <summary>
    /// SDNMediaManager configuration settings and constants
    /// </summary>
    public class Configuration
    {

        #region SQL Configuration....

        /// <summary>
        /// Username for accessing SQL Server
        /// </summary>
        public string SqlUsername { get; private set; } = "sa";

        /// <summary>
        /// Password for accessing SQL Server
        /// </summary>
        public string SqlPassword { get; private set; } = "A!12@lop^6";

        /// <summary>
        /// Hostname (Machine Name) of SQL Server machine
        /// </summary>
        public string SqlHostname { get; private set; } = "JimmyBeast-sdn";

        /// <summary>
        /// Database where SDN Media tables are stored
        /// </summary>
        public string SqlDatabase { get; private set; } = "SdnMedia";

        /// <summary>
        /// Name of SQL Server named instance, if applicable
        /// </summary>
        public string SqlInstance { get; private set; } = "/SQLEXPRESS";

        #endregion

        #region Event Log Configuration...

        //Event Log configuration details go here

        #endregion

        #region File Log Configuration...

        //Log file configuration details go here

        #endregion

    }
}
