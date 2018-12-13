using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using SDNMediaModels.DBContext;
using SDNMediaModels.Sort;

namespace DashboardUI.Controllers
{

    [Authorize]
    public class SortController : Controller
    {
        private MediaManagerDB db = new MediaManagerDB();

        public ActionResult DownloadDetails(string id)
        {
            MediaManagerDB dls = new MediaManagerDB();

            var model = dls.DownloadQueues.Where(e => e.pk_torrentID == id).First();
            return PartialView("_DownloadDetails", model);
        }

        public ActionResult GetDownloads()
        {
            MediaManagerDB dls = new MediaManagerDB();
            
            return View(dls.DownloadQueues);
        }

        public ActionResult GetContents()
        {
            return View();
        }

        public ActionResult sortItems_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<sortItem> sortitems = db.sortItems;
            DataSourceResult result = sortitems.ToDataSourceResult(request, MediaManagerDBModel => new {
                pk_MediaID = MediaManagerDBModel.pk_MediaID,
                filePath = MediaManagerDBModel.filePath,
                fileName = MediaManagerDBModel.fileName,
                fileNameSanitized = MediaManagerDBModel.fileNameSanitized,
                fk_fileMediaTypeID = MediaManagerDBModel.fk_fileMediaTypeID,
                fileAdded = MediaManagerDBModel.fileAdded,
                fileModified = MediaManagerDBModel.fileModified,
                hasBeenProcessed = MediaManagerDBModel.hasBeenProcessed,
                hasBeenSanitized = MediaManagerDBModel.hasBeenSanitized
            });

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult sortItems_Update([DataSourceRequest]DataSourceRequest request, sortItem MediaManagerDBModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new sortItem
                {
                    pk_MediaID = MediaManagerDBModel.pk_MediaID,
                    filePath = MediaManagerDBModel.filePath,
                    fileName = MediaManagerDBModel.fileName,
                    fileNameSanitized = MediaManagerDBModel.fileNameSanitized,
                    fk_fileMediaTypeID = MediaManagerDBModel.fk_fileMediaTypeID,
                    fileAdded = MediaManagerDBModel.fileAdded,
                    fileModified = MediaManagerDBModel.fileModified,
                    hasBeenProcessed = MediaManagerDBModel.hasBeenProcessed,
                    hasBeenSanitized = MediaManagerDBModel.hasBeenSanitized
                };

                db.sortItems.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(new[] { MediaManagerDBModel }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult sortItems_Destroy([DataSourceRequest]DataSourceRequest request, sortItem MediaManagerDBModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new sortItem
                {
                    pk_MediaID = MediaManagerDBModel.pk_MediaID,
                    filePath = MediaManagerDBModel.filePath,
                    fileName = MediaManagerDBModel.fileName,
                    fileNameSanitized = MediaManagerDBModel.fileNameSanitized,
                    fk_fileMediaTypeID = MediaManagerDBModel.fk_fileMediaTypeID,
                    fileAdded = MediaManagerDBModel.fileAdded,
                    fileModified = MediaManagerDBModel.fileModified,
                    hasBeenProcessed = MediaManagerDBModel.hasBeenProcessed,
                    hasBeenSanitized = MediaManagerDBModel.hasBeenSanitized
                };

                db.sortItems.Attach(entity);
                db.sortItems.Remove(entity);
                db.SaveChanges();
            }

            return Json(new[] { MediaManagerDBModel }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
