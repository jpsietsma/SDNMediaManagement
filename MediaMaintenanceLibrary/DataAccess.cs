using System.Collections.Generic;
using System.Configuration;

namespace MediaMaintenanceLibrary
{
    /// <summary>
    /// Contains the data access methods for returning data
    /// </summary>
    public static class DataAccess
    {
        /// <summary>
        /// Get connection string from web.config
        /// </summary>
        /// <param name="connName">Name of the connection string to retrieve</param>
        /// <returns>string representing connection string</returns>
        public static string GetConnectionString(string connName)
        {
            return ConfigurationManager.ConnectionStrings[connName].ConnectionString;
        }

        /// <summary>
        /// Gets the contents of a log file
        /// </summary>
        /// <param name="logPath">Path to the log file</param>
        /// <returns>string array containing lines of the log file</returns>
        public static string[] ReadLogFile(string logPath)
        {
            string[] finalContents = null;



            return finalContents;
        }
        
    }
}
