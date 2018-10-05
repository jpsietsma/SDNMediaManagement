using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static string[] ReadLogFile(string logPath)
        {
            string[] finalContents = null;



            return finalContents;
        }

        public static List<EventLogModel> ReadEventLog(string type = "default")
        {
            List<EventLogModel> finalEvents = new List<EventLogModel>();




            return finalEvents;
        }
    }
}
