using MediaMaintenanceLibrary.WinServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SortWatchdog.Library
{
    public class SortWatchdogLib : SortWatchdogServiceLibrary
    {
        public static void WorkerTimer(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer Ticked");
        }

        public static void SortWatcher_FileDropped(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($@"{ e.Name } dropped in sort folder.");
            Console.WriteLine();

            string uFileName = e.Name;



        }

    }
}
