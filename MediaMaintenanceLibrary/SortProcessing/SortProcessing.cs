using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;

namespace MediaMaintenanceLibrary.SortProcessing
{
    /// <summary>
    /// Deal with unprocessed sort items
    /// </summary>
    public class SortMediaFilenames
    {

        /// <summary>
        /// Process the file contents of the sort directory
        /// </summary>
        /// <param name="sortPath">Path to the sort directory</param>
        /// <returns>list of strings containing junk files</returns>
        public static List<string> ProcessJunk(string sortPath)
        {

            List<string> finalList = new List<string>();

            List<string> junkExtension = new List<string> { ".jpeg", ".txt", ".nfo", ".srt", ".url", ".lnk" };

            string[] tmpItems = Directory.GetFiles(sortPath);

            foreach (string file in tmpItems)
            {
                if (junkExtension.Contains(file.Split('.').Last()))
                {

                    finalList.Add(file);

                }
            }

            return finalList;
        }

        /// <summary>
        /// Sanitize file name of sort media item
        /// </summary>
        /// <param name="filename">Path to the file we want to sanitize</param>
        /// <returns>Sanitized name of file</returns>
        public static string SanitizeSortTitle(string filename)
        {
            string sanitizedName = string.Empty;

            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTitle.ps1 -filename '" + filename + "'";
                PowerShellInstance.AddScript(scriptPath);

                ICollection<PSObject> ps = PowerShellInstance.Invoke();

                foreach (PSObject item in ps)
                {

                    sanitizedName += item.ImmediateBaseObject.ToString();
                }

            }

            return sanitizedName;
        }



    }
}
