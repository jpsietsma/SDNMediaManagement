using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Moderator,User")]
        public ActionResult UserDashboard()
        {
            return View();
        }

    }
}