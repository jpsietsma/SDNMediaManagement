using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WinServices.SortWatchdog
{

    /// <summary>
    /// Windows service as console app using TopShelf which handles Sort media folder functions
    /// </summary>
    public class SDNMediaSortWatchdog
    {
        static void Main(string[] args)
        {

            var exitCode = HostFactory.Run(x =>
            {

                x.Service<SortWatchdogSvc>(s =>
                {
                    s.ConstructUsing(watchdog => new SortWatchdogSvc());
                    s.WhenStarted(watchdog => watchdog.Start());
                    s.WhenStopped(watchdog => watchdog.Stop());
                    s.WhenPaused(watchdog => watchdog.Pause());
                    s.WhenContinued(watchdog => watchdog.Resume());


                });

                //Set our user permissions for the service to run as local system
                //may need to change this in the future to support accessing UNC paths
                x.RunAsLocalSystem();

                //Allow us to additionally pause and resume the service as opposed to default of just stop/start
                x.EnablePauseAndContinue();

                //Automatic startup type
                x.StartAutomatically();

                //machine friendly name, no spaces
                x.SetServiceName("SDNSortWatchdogSvc");

                //User friendly name, spaces allowed
                x.SetDisplayName("SDN Sort Watchdog");

                //User friendly description for services.msc description
                x.SetDescription(@"This service performs various tasks in processing newly downloaded files inside the 'sort' directory such as renaming files, sanitizing the sort directory, and making sort files available for the Library Watchdog");
            });

            //convert our exit code into an int
            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());

            //set environment exit code so services recognize status changes via TopShelf
            Environment.ExitCode = exitCodeValue;

        }
    }
}
