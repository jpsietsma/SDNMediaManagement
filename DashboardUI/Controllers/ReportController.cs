﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SDNMediaModels.DBContext;
using SDNMediaModels.Feedback;


namespace DashboardUI.Controllers
{
    public class ReportController : Controller
    {
        private MediaManagerDB db = new MediaManagerDB();

        [Authorize]
        public ActionResult DownloadDuration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DownloadQueues_Read()
        {
            var dls = db.DownloadQueues.Where(d => d.DownloadDuration != null).ToList<DownloadQueue>();
            List<DownloadQueue> keep = new List<DownloadQueue>(dls);

            foreach (var dl in dls)
            {
                DateTime.TryParse(dl.DownloadStarted.ToString(), out DateTime started);
                DateTime.TryParse(dl.DownloadFinished.ToString(), out DateTime finished);
                     int.TryParse(DateTime.Now.ToString("dd"), out int day);

                if (!started.ToString("yyyy-MM-dd").Contains(DateTime.Today.ToString("yyyy")))
                {

                    //if download is not from this year, remove it
                    keep.Remove(dl);
                    
                }

                if (!started.ToString("yyyy-MM-dd").Contains(DateTime.Today.ToString("yyyy-MM")))
                {

                    //if download is not from this month, remove it
                    keep.Remove(dl);

                }

                if ((!started.ToString("yyyy-MM-dd").Contains(DateTime.Today.ToString($"yyyy-MM-dd"))))
                {

                    //if download is not from today or yesterday, remove it
                    keep.Remove(dl);

                }

            }

            return Json(keep.Take(50).Reverse().Select(downloadQueue => new {
                TorrentName = downloadQueue.TorrentName,
                DownloadFinished = downloadQueue.DownloadFinished,
                DownloadStarted = downloadQueue.DownloadStarted,
                TorrentStatus = downloadQueue.TorrentStatus,
                TorrentPath = downloadQueue.TorrentPath,
                DownloadDuration = downloadQueue.DownloadDuration,
                fileSize = downloadQueue.fileSize,
            }));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult StorageSpace(int? id)
        {
            if (!id.HasValue)
            {
                return View();
            }
            else
            {
                return View(db.list_MediaDrives);
            }

        }


    }
}
