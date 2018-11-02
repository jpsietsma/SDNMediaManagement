using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;


namespace MediaMaintenanceLibrary
{

    /// <summary>
    /// Methods for processing media files
    /// </summary>
    public static class MediaProcessing
    {

#region Sort Folder functions... 
                
        // SORT processing step 1
        /// <summary>
        /// Populates the 'sortitems' table in the database
        /// </summary>
        /// <param name="drive">path to the sort drive folder to scan into database</param>
        /// <returns>true on success, false on fail</returns>
        public static bool PopulateSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\PopulateSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);
                    PowerShellInstance.AddParameter("Path", drive);
                    PowerShellInstance.Invoke();
                }
                catch(Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        //SORT processing step 2
        /// <summary>
        /// Sanitize the file names of files in the sort folder
        /// </summary>
        /// <param name="drive">Path to the sort folder to sanitize</param>
        /// <returns>true on success, false on fail</returns>
        public static bool SanitizeSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try
                {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);

                    //PowerShellInstance.AddParameter("FileName", fileName);

                    PowerShellInstance.Invoke();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        //SORT processing step 3
        /// <summary>
        /// Finalizes the contents of the sort table for distribution
        /// </summary>
        /// <param name="drive">Path to the sort folder to finalize</param>
        /// <returns>True on success, false on fail</returns>
        public static bool FinalizeSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try
                {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);

                    //PowerShellInstance.AddParameter("FileName", fileName);

                    PowerShellInstance.Invoke();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

        //SORT processing step 4
        /// <summary>
        /// Moves finalized files to the live media library after finalized
        /// </summary>
        /// <param name="drive">Path to the sort folder</param>
        /// <returns>True on success, false on fail</returns>
        public static bool DistributeSortTable(string drive = @"S:\")
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                try
                {
                    string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTable.ps1";
                    PowerShellInstance.AddScript(scriptPath);

                    //PowerShellInstance.AddParameter("FileName", fileName);

                    PowerShellInstance.Invoke();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }

            return true;
        }

#endregion

    }
}
