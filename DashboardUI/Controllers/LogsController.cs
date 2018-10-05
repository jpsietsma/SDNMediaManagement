using DashboardUI.Areas.LogsDashboard.Models;
using DashboardUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
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
            List<downloadHistory> downloadLogs = new List<downloadHistory>();

            string[] files = Directory.GetFiles(@"S:\~drops\tvdrop");

            foreach (string file in files)
            {

                downloadLogs.Add(new downloadHistory(file));

            }

            return View(downloadLogs);
        }
        
    }
}