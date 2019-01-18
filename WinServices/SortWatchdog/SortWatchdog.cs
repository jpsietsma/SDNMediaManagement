using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using SortWatchdog.Library;

namespace WinServices.SortWatchdog
{
    public class SortWatchdogSvc
    {
        static readonly string WatchPath = @"S:\";
        static readonly string FileFilter = @"*.*";
        public bool TimerRunning = false;

        public FileSystemWatcher sortWatcher = new FileSystemWatcher(WatchPath, FileFilter);
        public Timer _timer = new Timer(5000);       
                        
        public SortWatchdogSvc()
        {
            //Future constructor code in here
        }        

        public void Start()
        {
            _timer.Elapsed += SortWatchdogLib.WorkerTimer;

            //Start our timer when the service is started
            _timer.Start();
            TimerRunning = true;

            //Start listening to folder for file create events
            sortWatcher.Created += SortWatchdogLib.SortWatcher_FileDropped;
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
