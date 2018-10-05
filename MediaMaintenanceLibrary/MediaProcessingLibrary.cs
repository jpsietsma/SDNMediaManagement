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
    public static class MediaProcessingLibrary
    {

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

            //Gather junk and add full paths to finalList list

            return finalList;
        }

        //public static async bool MoveSortFile(List<object> sortMoveList)
        //{


        //    return true;
        //}

        public static List<object> GetShowSeasons(int id)
        {
            List<object> finalSeasons = null;


            return finalSeasons;
        }

        public static List<object> GetShowSeasonEpisodes(int id)
        {
            List<object> finalEpisodes = null;


            return finalEpisodes;
        }

        public static string SanitizeSortTitle(string filename)
        {
            string sanitizedName = string.Empty;

            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                string scriptPath = @"C:\Users\JimmyS\OneDrive\GitHub\SDNMediaManagement\MediaMaintenanceLibrary\Scripts\powershell\SanitizeSortTitle.ps1 -filename '" + filename + "'" ;
                PowerShellInstance.AddScript(scriptPath);

                ICollection <PSObject> ps = PowerShellInstance.Invoke();

                foreach(PSObject item in ps)
                {

                    sanitizedName += item.ImmediateBaseObject.ToString();
                }

            }

            return sanitizedName;
        }

        // SORT processing step 1
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

        //SORT processing step 4 - final step
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


    }
}
