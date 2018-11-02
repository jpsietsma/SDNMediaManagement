using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

using SDNMediaModels.DBContext;
using SDNMediaModels.Feedback;

namespace DashboardUI.Controllers
{
    public class FeedbackController : Controller
    {
        private MediaManagerDB db = new MediaManagerDB();

        [Authorize]
        public ActionResult Index()
        {
            return View(db.UserRequests.Where(r => r.RequestCompleted == 0).ToList());
        }

        public ActionResult RequestMedia()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_RequestID,RequestQuery,RequestType,RequestSubtype,ExistingSeries,RequestShow,RequestSeason,RequestEpisode,RequestMovie,RequestMovieYear,RequestMovieGenre,RequestCompleted")] UserRequest request)
        {
            if (ModelState.IsValid)
            {
                db.UserRequests.Add(request);
                db.SaveChanges();
                return RedirectToAction("RequestMedia");
            }

            return View(request);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserRequest requestedMediaItemModel = db.UserRequests.Where(s => s.pk_RequestID == id).FirstOrDefault();

            if (requestedMediaItemModel == null)
            {
                return HttpNotFound();
            }

            return View(requestedMediaItemModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_RequestID,RequestQuery,RequestType,RequestSubtype,ExistingSeries,RequestShow,RequestSeason,RequestEpisode,RequestMovie,RequestMovieYear,RequestMovieGenre")] UserRequest request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(request);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Tasks()
        {
            return View(db.TaskQueues);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
