using SDNMediaModels.DBContext;
using SDNMediaModels.Television;
using System.Linq;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    public partial class AutoCompleteController : Controller
    {

        public ActionResult ServerFiltering()
        {
            return View();
        }

        public ActionResult ServerFiltering_GetShows(string searchTerm)
        {
            using (var shows_db = new MediaManagerDB())
            {

                var shows = shows_db.TelevisionShows.Select(show => new TelevisionShow
                {
                    pk_ShowID = show.pk_ShowID,
                    ShowName = show.ShowName,
                    ShowNumSeasons = show.ShowNumSeasons,
                    ShowNumEpisodes = show.ShowNumEpisodes,
                    ShowDriveLetter = show.ShowDriveLetter,
                    ShowHomePath = show.ShowHomePath

                });

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    shows = shows.Where(s => s.ShowName.Contains(searchTerm));
                }

                return Json(shows, JsonRequestBehavior.AllowGet);
            }  
            
        }


    }
}