using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    public partial class UploadController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Basic_Usage_Submit(IEnumerable<HttpPostedFileBase> files)
        {
            if (files != null)
            {
                TempData["UploadedFiles"] = Basic_Usage_Get_File_Info(files);
            }

            return RedirectToAction("Result");
        }

        public ActionResult Result()
        {
            return View();
        }

        private IEnumerable<string> Basic_Usage_Get_File_Info(IEnumerable<HttpPostedFileBase> files)
        {
            return
                from a in files
                where a != null
                select string.Format("{0} ({1} bytes)", Path.GetFileName(a.FileName), a.ContentLength);
        }
    }
}