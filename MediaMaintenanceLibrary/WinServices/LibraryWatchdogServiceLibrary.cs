using SDNMediaModels.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.WinServices
{
    /// <summary>
    /// Class to handle Library Watchdog windows service actions
    /// </summary>
    public class LibraryWatchdogServiceLibrary
    {

        public static bool CreateNewShow(ShowAiringStatus uShowAirStatus, string uShowName, int uShowNumSeasons = 0)
        {
            bool finalStatus = false;
            int numSeasons;

            if (uShowNumSeasons != 0)
            {
                numSeasons = uShowNumSeasons;
            }


            return finalStatus;
        }


        public static bool CreateNewShow(ShowAiringStatus uShowAirStatus, string uShowName)
        {
            bool finalStatus = false;


            return finalStatus;
        }


        public static bool CreateNewShow(string uShowName, int uShowNumSeasons = 0, ShowAiringStatus uShowAiringStatus = ShowAiringStatus.OTHER)
        {
            bool finalStatus = false;


            return finalStatus;
        }


        public static string NewShowPathBuilder()
        {
            string finalpath = string.Empty;

            return finalpath;
        }

    }
}
