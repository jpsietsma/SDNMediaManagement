using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.Apis
{
    /// <summary>
    /// Class to manage and display torrents currently added to Deluge
    /// </summary>
    public static class DelugeApiLibrary
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool AuthenticateDelugeWeb(string delugeWebuiPassword, string delugeHostname = "", int delugeWebPort = 8080)
        {
            bool finalStatus = false;
            string url = $@"http://{ delugeHostname }:{ delugeWebPort }/json";




            return finalStatus;
        }

    }
}
