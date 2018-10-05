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
                            MediaMaintenanceLibrary.MediaProcessingLibrary.PopulateSortTable();
                        }

                        catch (Exception ex) { Console.WriteLine(ex.Message); }

                        return RedirectToAction("GetContents", "Sort");

                    }

                case "sanitize":
                    {

                        try
                        {
                            MediaMaintenanceLibrary.MediaProcessingLibrary.SanitizeSortTable();
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
                MediaMaintenanceLibrary.MediaProcessingLibrary.PopulateSortTable();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return RedirectToAction("GetContents", "Sort");
        }

        public ActionResult FinalizeSort()
        {

            try
            {
                MediaMaintenanceLibrary.MediaProcessingLibrary.FinalizeSortTable();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return RedirectToAction("GetContents", "Sort");
        }

        public ActionResult DistributeSort()
        {

            try
            {
                MediaMaintenanceLibrary.MediaProcessingLibrary.DistributeSortTable();
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return RedirectToAction("PopulateSort", "Maintenance");

        }
    }
}