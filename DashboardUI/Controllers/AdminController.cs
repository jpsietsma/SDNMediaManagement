using DashboardUI.Items;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class AdminController : Controller
    {

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Schedule()
        {
            return View();
        }

        public ActionResult ManageUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();


            return View(db.Users);
        }
    }
}