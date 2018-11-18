using SDNMediaModels.DBContext;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.TvShows
{

    /// <summary>
    /// Class for accessing and altering existing shows in the media library
    /// </summary>
    public static class ShowProcessing
    {

        /// <summary>
        /// Sets a show as active in SDN Media Manager, makes visible in searches and library.
        /// </summary>
        /// <param name="showID">Show ID of the show to activate show</param>
        /// <param name="conn">DBContext to SQL to use to activate</param>
        /// <returns>True if show is activated successfully</returns>
        public static bool ActivateShow(int showID, MediaManagerDB conn)
        {
            bool finalResult;

            using (conn)
            {
                var db = conn.ActivateShow(showID);

                if (db == 1)
                {
                    finalResult = true;
                }
                else
                {
                    finalResult = false;
                }
            }            

            return finalResult;
        }

        /// <summary>
        /// Activates the show in the SDN Media Manager allowing it to be searched and watched
        /// </summary>
        /// <param name="show">Model of show to activate</param>
        /// <param name="conn">DBContext connection to use to activate show</param>
        /// <returns>true if activated successfully</returns>
        public static bool ActivateShow(this TelevisionShow show, MediaManagerDB conn)
        {
            bool finalResult;

            using (conn)
            {
                var db = conn.ActivateShow(show.pk_ShowID);

                if (db == 1)
                {
                    finalResult = true;
                }
                else
                {
                    finalResult = false;
                }
            }

            return finalResult;
        }

        /// <summary>
        /// Deactivates the show in the SDN Media Manager disallowing it from being searched and watched
        /// </summary>
        /// <param name="showID">Model of show to deactivate</param>
        /// <param name="conn">DBContext connection to use to deactivate show</param>
        /// <returns>true if deactivated successfully</returns>
        public static bool DeactivateShow(int showID, MediaManagerDB conn)
        {
            bool finalResult;

            using (conn)
            {
                var db = conn.DeactivateShow(showID);

                if (db == 1)
                {
                    finalResult = true;
                }
                else
                {
                    finalResult = false;
                }
            }

            return finalResult;
        }

        /// <summary>
        /// Deactivates the show in the SDN Media Manager disallowing it from being searched and watched
        /// </summary>
        /// <param name="show">Model of show to deactivate</param>
        /// <param name="conn">DBContext connection to use to deactivate show</param>
        /// <returns>true if deactivated successfully</returns>
        public static bool DeactivateShow(this TelevisionShow show, MediaManagerDB conn)
        {
            bool finalResult;

            using (conn)
            {
                var db = conn.DeactivateShow(show.pk_ShowID);

                if (db == 1)
                {
                    finalResult = true;
                }
                else
                {
                    finalResult = false;
                }
            }

            return finalResult;
        }


    }
}
