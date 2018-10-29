using System.Collections.Generic;
using System.Configuration;
using SDNMediaModels.EventLog;

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
        /// Sets the connection string in the web config file with the provided name
        /// </summary>
        /// <param name="connName">Name to be used for connection string</param>
        public static void SetConnectionString(string connName)
        {
            //code goes here to process and set connection string based on name
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

        /// <summary>
        /// Reads the event log for the SDNMedia application
        /// </summary>
        /// <param name="type">type of events to grab</param>
        /// <returns>list of event log models</returns>
        public static List<IEventLogModel> ReadEventLog(string type = "default")
        {
            List<IEventLogModel> finalEvents = new List<IEventLogModel>();




            return finalEvents;
        }
    }
}
