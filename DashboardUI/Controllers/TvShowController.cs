using DashboardUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    public class TvShowController : Controller
    {
       
        // GET: TvShow
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AiringSchedules()
        {

            return View();
        }

    }
}