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