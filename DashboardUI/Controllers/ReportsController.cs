using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult TelevisionMaster()
        {
            return View();
        }
    }
}