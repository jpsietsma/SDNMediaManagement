using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.WinServices
{
    /// <summary>
    /// Class to handle Windows Sort Watchdog Service actions
    /// </summary>
    public class SortWatchdogServiceLibrary
    {
        /// <summary>
        /// check to see if show exists in database
        /// </summary>
        /// <returns>Boolean true if show exists, false if it doesn't</returns>
        public static bool IsExistingShow(string showName)
        {
            bool finalStatus;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MediaManagerDB"].ConnectionString))
            {
                conn.Open();

                try
                {
                    SqlCommand sqlQuery = new SqlCommand($@"SELECT * FROM TelevisionShows WHERE ShowName = { showName }");
                    int numResults = sqlQuery.ExecuteNonQuery();

                    if (numResults == 1)
                    {
                        Console.WriteLine("Show was found!");
                        finalStatus = true;
                    }
                    else
                    {
                        Console.WriteLine("New Show Detected!");
                        finalStatus = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    finalStatus = false;
                }

                conn.Close();
            }

            finalStatus = false;            

            return finalStatus;
        }

        /// <summary>
        /// Get free drive space of passed drive
        /// </summary>
        /// <param name="driveLetter">Letter of drive to check</param>
        /// <returns>amount of free space in MB</returns>
        public static double GetFreeDriveSpace(char driveLetter)
        {
            double finalSpace = 0;

            DriveInfo driveInfo = new DriveInfo(driveLetter.ToString());
                finalSpace = driveInfo.AvailableFreeSpace;

            return finalSpace;
        }

        /// <summary>
        /// Get total drive space of passed drive
        /// </summary>
        /// <param name="driveLetter">Letter of drive to check</param>
        /// <returns>Total drive space in MB</returns>
        public static double GetTotalDriveSpace(char driveLetter)
        {
            double finalSpace = 0;

            DriveInfo driveInfo = new DriveInfo(driveLetter.ToString());
                finalSpace = driveInfo.TotalSize;
            
            return finalSpace;
        }

    }
}
