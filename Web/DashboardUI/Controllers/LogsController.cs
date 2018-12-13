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
        
    }
}