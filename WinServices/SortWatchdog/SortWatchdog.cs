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

        private readonly Timer _timer = new Timer(5000);
        public bool TimerRunning = false;
        
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
            //Execute method TimerElapsed when timer elapses every 5 seconds
            _timer.Elapsed += TimerElapsed;

            //Start our timer when the service is started
            _timer.Start();

            //Set TimerRunning to true as we have started the timer
            TimerRunning = true;
        }

        public void Stop()
        {
            //Stop timer when service is started
            _timer.Stop();

            //Set TimerRunning to false as we have stopped the service
            TimerRunning = false;
        }

        public void Pause()
        {
            _timer.Stop();

            TimerRunning = false;
        }

        public void Resume()
        {
            _timer.Start();

            TimerRunning = true;
        }



    }
}
