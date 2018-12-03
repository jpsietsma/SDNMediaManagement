using MediaMaintenanceLibrary;
using MediaMaintenanceLibrary.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinServices.SortWatchdog
{
    public class SortWatchdogSvc
    {

        private readonly Timer _timer;

        public SortWatchdogSvc()
        {
            //Future constructor code in here
        }

        public void TimerElapsed(object sender, ElapsedEventArgs e)
        {

            string[] lines = new string[] { "Test Write Message" };
            File.AppendAllLines($@"{ MediaManagerConfiguration.SDNLogPath }{ DateTime.Now.ToString("dd-MM-yyyy") }_sortlib_notificationLog.txt", lines);

        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }



    }
}
