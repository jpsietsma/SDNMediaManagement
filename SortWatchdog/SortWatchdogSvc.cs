using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SortWatchdog
{
    public partial class SortWatchdogSvc : ServiceBase
    {
        public SortWatchdogSvc()
        {
            InitializeComponent();           

            EventLog eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";

        }

        protected override void OnStart(string[] args)
        {
            FileSystemWatcher sortWatcher = new FileSystemWatcher();
                sortWatcher.Path = @"S:\";
                sortWatcher.NotifyFilter = NotifyFilters.LastWrite;
                sortWatcher.Filter = "*.*";
                sortWatcher.Created += new FileSystemEventHandler(sortWatcher_FileAdded);
                sortWatcher.EnableRaisingEvents = true;

            void sortWatcher_FileAdded(object sender, FileSystemEventArgs e)
            {

                

            }

        }

        protected override void OnStop()
        {
        }
    }
}
