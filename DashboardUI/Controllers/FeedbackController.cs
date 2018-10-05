using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DashboardUI;
using DashboardUI.Models;

namespace DashboardUI.Controllers
{
    public class FeedbackController : Controller
    {
        private RequestedMediaItem db = new RequestedMediaItem();
        private TaskModelItem db_tasks = new TaskModelItem();

        [Authorize]
        public ActionResult Index()
        {
            RequestedMediaItem db = new RequestedMediaItem();

            return View(db.requests.Where(r => r.RequestCompleted == 0).ToList());
        }

        // GET: Feedback/Create

        public ActionResult RequestMedia()
        {
            return View("Create");
        }

        // POST: Feedback/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pk_RequestID,RequestQuery,RequestType,RequestSubtype,ExistingSeries,RequestShow,RequestSeason,RequestEpisode,RequestMovie,RequestMovieYear,RequestMovieGenre,RequestCompleted")] RequestedMediaItemModel requestedMediaItemModel)
        {
            if (ModelState.IsValid)
            {
                db.requests.Add(requestedMediaItemModel);
                db.SaveChanges();
                return RedirectToAction("RequestMedia");
            }

            return View(requestedMediaItemModel);
        }

        // GET: Feedback/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestedMediaItemModel requestedMediaItemModel = db.requests.Find(id);
            if (requestedMediaItemModel == null)
            {
                return HttpNotFound();
            }
            return View(requestedMediaItemModel);
        }

        // POST: Feedback/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pk_RequestID,RequestQuery,RequestType,RequestSubtype,ExistingSeries,RequestShow,RequestSeason,RequestEpisode,RequestMovie,RequestMovieYear,RequestMovieGenre")] RequestedMediaItemModel requestedMediaItemModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestedMediaItemModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestedMediaItemModel);
        }

        [Authorize]
        public ActionResult Tasks()
        {
            TaskModelItem tasks = new TaskModelItem();

            return View(tasks.taskItems);
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
