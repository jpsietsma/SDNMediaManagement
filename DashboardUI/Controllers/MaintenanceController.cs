using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    [Authorize]
    public class MaintenanceController : Controller
    {
        // GET: Maintenance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExecutePS(string id)
        {
            switch (id)
            {
                case "populate":
                    {

                        try
                        {
                            MediaMaintenanceLibrary.MediaProcessing.PopulateSortTable();
                        }

                        catch (Exception ex) { Console.WriteLine(ex.Message); }

                        return RedirectToAction("GetContents", "Sort");

                    }

                case "sanitize":
                    {

                        try
                        {
                            MediaMaintenanceLibrary.MediaProcessing.SanitizeSortTable();
                        }

                        catch (Exception ex) { Console.WriteLine(ex.Message); }

                        return RedirectToAction("GetContents", "Sort");

                    }
            }         

            return RedirectToAction("ExecutePS", "Maintenance", new { id = "populate" });
        }

        public ActionResult SanitizeSort()
        {

            try
            {
                MediaMaintenanceLibrary.MediaProcessing.PopulateSortTable();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return RedirectToAction("GetContents", "Sort");
        }

        public ActionResult FinalizeSort()
        {

            try
            {
                MediaMaintenanceLibrary.MediaProcessing.FinalizeSortTable();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return RedirectToAction("GetContents", "Sort");
        }

        public ActionResult DistributeSort()
        {

            try
            {
                MediaMaintenanceLibrary.MediaProcessing.DistributeSortTable();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return RedirectToAction("PopulateSort", "Maintenance");

        }
    }
}