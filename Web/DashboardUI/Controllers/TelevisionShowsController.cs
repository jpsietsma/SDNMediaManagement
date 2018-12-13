using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SDNMediaModels.DBContext;
using SDNMediaModels.Television;

namespace DashboardUI.Controllers
{
    public class TelevisionShowsController : Controller
    {
        private MediaManagerDB db = new MediaManagerDB();

        // GET: TelevisionShows
        public ActionResult Index()
        {
            return View(db.TelevisionShows.ToList());
        }

        // GET: TelevisionShows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelevisionShow televisionShow = db.TelevisionShows.Find(id);
            if (televisionShow == null)
            {
                return HttpNotFound();
            }
            return View(televisionShow);
        }

        // GET: TelevisionShows/Create
        public ActionResult CreateShow()
        {
            return View();
        }

        // POST: TelevisionShows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateShow([Bind(Include = "ShowName,ShowDriveLetter,ShowHomePath,ShowNumSeasons,ShowNumEpisodes,ShowAlbumArtPath,IsEnabled,TvdbID,ImdbID,fk_MediaType")] TelevisionShow televisionShow)
        {
            if (ModelState.IsValid)
            {
                db.TelevisionShows.Add(televisionShow);
                db.SaveChanges();
                return RedirectToAction("SeasonInfo", "Media", new { Id = db.TelevisionShows.First(s => s.ShowName == televisionShow.ShowName) });
            }

            return View(televisionShow);
        }

        // GET: TelevisionShows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelevisionShow televisionShow = db.TelevisionShows.Find(id);
            if (televisionShow == null)
            {
                return HttpNotFound();
            }
            return View(televisionShow);
        }

        // POST: TelevisionShows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_ShowID,ShowName,ShowDriveLetter,ShowHomePath,ShowNumSeasons,ShowNumEpisodes,ShowAlbumArtPath,IsEnabled,TvdbID,ImdbID,fk_MediaType")] TelevisionShow televisionShow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(televisionShow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(televisionShow);
        }

        // GET: TelevisionShows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelevisionShow televisionShow = db.TelevisionShows.Find(id);
            if (televisionShow == null)
            {
                return HttpNotFound();
            }
            return View(televisionShow);
        }

        // POST: TelevisionShows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TelevisionShow televisionShow = db.TelevisionShows.Find(id);
            db.TelevisionShows.Remove(televisionShow);
            db.SaveChanges();
            return RedirectToAction("Index");
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
