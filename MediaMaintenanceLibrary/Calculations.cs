using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary
{
    /// <summary>
    /// Used when performing calculations and formatting to data before it is displayed to the user
    /// </summary>
    public static class Calculations
    {
        /// <summary>
        /// Calculate time it took to complete download
        /// </summary>
        /// <param name="minutes">integer representing number of minutes that download took</param>
        /// <returns>Tuple in the form of '{# of days}, {# of Hours},{# of Minutes}' representing download duration</returns>
        public static string CalculateDownloadDuration(int minutes)
        {
            Tuple<string, string, string> finalDuration = null;

            int finalDays = minutes/1440;
            minutes = minutes - (finalDays * 1440);
            int finalHours = minutes/60;
            minutes = minutes - (finalHours * 60);
            int finalMinutes = minutes;
            
            finalDuration = Tuple.Create(finalDays + " Days", finalHours + " Hours", finalMinutes + " Minutes");

            return finalDuration.Item1 + ", " + finalDuration.Item2 + ", " + finalDuration.Item3;
        }

        /// <summary>
        /// Calculate the Average Mb/s of the download
        /// </summary>
        /// <param name="minutes">Total download duration in minutes</param>
        /// <param name="fileSize">Total download file size in Mb</param>
        /// <returns>string in the form {Average Download Speed of xx.xx Mb/s}</returns>
        public static string CalculateMbpsAvg(int minutes, double fileSize)
        {
            string finalAvg = string.Empty;
            double.TryParse(minutes.ToString(), out double dMinutes);

            finalAvg = Math.Round((fileSize / (dMinutes * 60)), 4).ToString();

            return "Average Download Speed of " + finalAvg + " Mb/s";
        }
    }
}
