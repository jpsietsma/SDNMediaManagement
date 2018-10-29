using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DashboardUI.Items;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using SDNMediaModels.Sort;

namespace DashboardUI.Controllers
{

    [Authorize]
    public class SortController : Controller
    {
        private SortMediaItem db = new SortMediaItem();

        public ActionResult DownloadDetails(string id)
        {
            MediaDownloadItem dls = new MediaDownloadItem();

            var model = dls.sdnDownloadItems.Where(e => e.pk_torrentID == id).First();
            return PartialView("_DownloadDetails", model);
        }

        public ActionResult GetDownloads()
        {
            MediaDownloadItem dls = new MediaDownloadItem();
            
            return View(dls.sdnDownloadItems);
        }

        public ActionResult GetContents()
        {
            return View();
        }

        public ActionResult sortItems_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<ISortMediaItemModel> sortitems = db.sortItems;
            DataSourceResult result = sortitems.ToDataSourceResult(request, sortMediaItemModel => new {
                pk_MediaID = sortMediaItemModel.pk_MediaID,
                filePath = sortMediaItemModel.filePath,
                fileName = sortMediaItemModel.fileName,
                fileNameSanitized = sortMediaItemModel.fileNameSanitized,
                fk_fileMediaTypeID = sortMediaItemModel.fk_fileMediaTypeID,
                fileAdded = sortMediaItemModel.fileAdded,
                fileModified = sortMediaItemModel.fileModified,
                hasBeenProcessed = sortMediaItemModel.hasBeenProcessed,
                hasBeenSanitized = sortMediaItemModel.hasBeenSanitized
            });

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult sortItems_Update([DataSourceRequest]DataSourceRequest request, ISortMediaItemModel sortMediaItemModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new SortMediaItemModel
                {
                    pk_MediaID = sortMediaItemModel.pk_MediaID,
                    filePath = sortMediaItemModel.filePath,
                    fileName = sortMediaItemModel.fileName,
                    fileNameSanitized = sortMediaItemModel.fileNameSanitized,
                    fk_fileMediaTypeID = sortMediaItemModel.fk_fileMediaTypeID,
                    fileAdded = sortMediaItemModel.fileAdded,
                    fileModified = sortMediaItemModel.fileModified,
                    hasBeenProcessed = sortMediaItemModel.hasBeenProcessed,
                    hasBeenSanitized = sortMediaItemModel.hasBeenSanitized
                };

                db.sortItems.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(new[] { sortMediaItemModel }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult sortItems_Destroy([DataSourceRequest]DataSourceRequest request, ISortMediaItemModel sortMediaItemModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new SortMediaItemModel
                {
                    pk_MediaID = sortMediaItemModel.pk_MediaID,
                    filePath = sortMediaItemModel.filePath,
                    fileName = sortMediaItemModel.fileName,
                    fileNameSanitized = sortMediaItemModel.fileNameSanitized,
                    fk_fileMediaTypeID = sortMediaItemModel.fk_fileMediaTypeID,
                    fileAdded = sortMediaItemModel.fileAdded,
                    fileModified = sortMediaItemModel.fileModified,
                    hasBeenProcessed = sortMediaItemModel.hasBeenProcessed,
                    hasBeenSanitized = sortMediaItemModel.hasBeenSanitized
                };

                db.sortItems.Attach(entity);
                db.sortItems.Remove(entity);
                db.SaveChanges();
            }

            return Json(new[] { sortMediaItemModel }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
