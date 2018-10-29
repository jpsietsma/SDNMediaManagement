using SDNMediaModels.Logs;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    public class LogsController : Controller
    {
        // GET: Logs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DownloadHistory(string id)
        {
            List<IDownloadHistory> downloadLogs = new List<IDownloadHistory>();

            string[] files = Directory.GetFiles(@"S:\~drops\tvdrop");

            foreach (string file in files)
            {

                downloadLogs.Add(new DownloadHistory(file));

            }

            return View(downloadLogs);
        }
        
    }
}