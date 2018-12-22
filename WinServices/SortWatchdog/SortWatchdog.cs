using MediaMaintenanceLibrary;
using MediaMaintenanceLibrary.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinServices.SortWatchdog
{
    public class SortWatchdogSvc
    {
        static string watchPath = @"S:\";
        static string fileFilter = @"*.*";
        public bool TimerRunning = false;

        public FileSystemWatcher sortWatcher = new FileSystemWatcher(watchPath, fileFilter);
        private readonly Timer _timer = new Timer(5000);
        
        public SortWatchdogSvc()
        {
            //Future constructor code in here
        }

        public void WorkerTimer(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer Ticked");
        }

        private void SortWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($@"{ e.Name } dropped in sort folder.");
            Console.WriteLine();
        }

        public void Start()
        {
            //Start our timer when the service is started
            _timer.Elapsed += WorkerTimer;
            _timer.Start();
            TimerRunning = true;

            //Start listening to folder for file create events
            sortWatcher.Created += SortWatcher_Created;
            sortWatcher.EnableRaisingEvents = true;
        }

        public void Stop()
        {
            //Stop timer when service is stopped
            _timer.Stop();
            TimerRunning = false;

            //Stop listening to folder for file drop events
            sortWatcher.EnableRaisingEvents = false;
        }

        public void Pause()
        {
            //Stop timer when service is stopped
            _timer.Stop();
            TimerRunning = false;

            //Stop listening to folder for file drop events
            sortWatcher.EnableRaisingEvents = false;
        }

        public void Resume()
        {
            _timer.Start();
            TimerRunning = true;

            //Start listening to folder for file create events
            sortWatcher.EnableRaisingEvents = true;
        }
               
    }
}
