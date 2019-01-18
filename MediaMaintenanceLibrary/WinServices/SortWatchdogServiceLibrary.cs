using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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

        /// <summary>
        /// Begin running Sort Precheck steps 1 - 3
        /// </summary>
        /// <returns>true if all prechecks pass, false if any fail</returns>
        public bool RunSortPrechecks()
        {
            if (RunPrecheckStep1(out int numRecycledFiles, out List<string> recycledFiles) && RunPrecheckStep2(out int numDuplicateEpisodes) && RunPrecheckStep3(out int numTrackedEpisodes))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Runs pre-check 1: log and move .txt, .jpg, .jpeg, to recycle folder
        /// </summary>
        /// <returns>Returns true if check runs successfully</returns>
        public virtual bool RunPrecheckStep1(out int numRecycledFiles, out List<string> recycledFiles)
        {
            recycledFiles = new List<string>();

            numRecycledFiles = recycledFiles.Count();

            return false;
        }

        /// <summary>
        /// Runs pre-check 2: Check for duplicate episodes and duplicate existing episodes and move to recycle folder
        /// </summary>
        /// <returns>Returns true if check runs successfully</returns>
        public virtual bool RunPrecheckStep2(out int numDuplicateEpisodes)
        {
            numDuplicateEpisodes = 0;

            return false;
        }

        /// <summary>
        /// Runs pre-check 3: Build list of files that passed check, check for tracked shows and move
        /// </summary>
        /// <returns>Returns true if check runs successfully</returns>
        public virtual bool RunPrecheckStep3(out int numTrackedEpisodes)
        {
            numTrackedEpisodes = 0;

            return false;
        }

    }
}
