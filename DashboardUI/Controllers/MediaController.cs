
using Kendo.Mvc.Extensions;
using SDNMediaModels.DBContext;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    [Authorize]
    public class MediaController : Controller
    {

#region Navigation Actions/Views...

        //header nav and show search autocomplete related code will go here

        #endregion

#region Episode Action / Views...

        public ActionResult WatchEpisode(int id)
        {
            MediaManagerDB db_episodes = new MediaManagerDB();

            var model = db_episodes.TelevisionEpisodes.Where(x => x.pk_EpisodeID == id).Where(episode => episode.IsEnabled.Equals(1)).First();
            return PartialView("_WatchEpisode", model);
        }

        public ActionResult EditEpisodeDetails(int id)
        {
            MediaManagerDB db_episodes = new MediaManagerDB();

            var model = db_episodes.TelevisionEpisodes.Where(e => e.pk_EpisodeID == id).Where(episode => episode.IsEnabled.Equals(1)).First();
            return PartialView("_EditEpisode", model);
        }

        public ActionResult EpisodeDetails(int id)
        {
            MediaManagerDB db_episodes = new MediaManagerDB();

            return View(db_episodes.TelevisionEpisodes.Where(e => e.pk_EpisodeID == id).Where(episode => episode.IsEnabled.Equals(1)).First());
        }

        public ActionResult EpisodeInfo(int id)
        {
            MediaManagerDB db_episodes = new MediaManagerDB();

            return View(db_episodes.TelevisionEpisodes.Where(episodes => episodes.fk_SeasonID == id).OrderBy(o => o.EpisodeNum).Where(episode => episode.IsEnabled.Equals(1)));
        }

#endregion

#region Season Actions / Views...

        //Lists all seasons of the show who's id is passed
        public ActionResult SeasonInfo(int id)
        {
            MediaManagerDB db_seasons = new MediaManagerDB();

            return View(db_seasons.TelevisionSeasons.Where(season => season.fk_ShowID.Equals(id)).Where(season => season.IsEnabled.Equals(1)));

        }

        //Plays season with episodes populated in playlist
        public ActionResult WatchSeason(int id)
        {
            MediaManagerDB db_episodes = new MediaManagerDB();
            List<ITelevisionEpisode> episodes = db_episodes.TelevisionEpisodes.Where(e => e.fk_SeasonID == id).Where(e => e.IsEnabled.Equals(1)).ToList<ITelevisionEpisode>();

            return PartialView("_WatchSeason", episodes);
        }

        //Show view to create new season
        public ActionResult AddSeason(int id)
        {
            MediaManagerDB shows_db = new MediaManagerDB();
            ITelevisionShow show = shows_db.TelevisionShows.Where(showDetails => showDetails.pk_ShowID == id).FirstOrDefault();

            return View(show);
        }

        //Add new season model created and save changes to database, redirect to seasons listing of parent show
        public ActionResult SaveSeason(ITelevisionSeason newSeason)
        {
            //SietsmaDevMediaModel db = new SietsmaDevMediaModel();
            //seasons.SaveChanges();

            return RedirectToAction("SeasonInfo", new { id = newSeason.fk_ShowID });
        }

        #endregion

#region Series Actions / Views...

        /// <summary>
        /// Display form for adding a new show to the database
        /// </summary>
        /// <returns>
        /// Add Show view form
        /// </returns>
        public ActionResult AddShow()
        {
            return View();
        }

        /// <summary>
        /// Action to add show to database
        /// </summary>
        /// <param name="newShow">ITelevisionShow representing show to be added</param>
        /// <returns>redirect to list of shows when successful</returns>
        public ActionResult AddShow(TelevisionShow newShow)
        {
            MediaManagerDB shows = new MediaManagerDB();

            shows.TelevisionShows.Add(newShow);
            shows.SaveChanges();

            return RedirectToAction("ShowInfo");

        }

        /// <summary>
        /// Displays view with form for adding new sort item to the database
        /// </summary>
        /// <returns>form for adding a new sort item</returns>
        public ActionResult AddSortItem()
        {
            MediaManagerDB items = new MediaManagerDB();

            return View();
        }

        /// <summary>
        /// Action to add sort item to the database
        /// </summary>
        /// <param name="newItem">MediaManagerDBModel representing the new item to add to the database</param>
        /// <returns>
        /// redirect to view displaying kendoui grid with all sort items
        /// </returns>
        public ActionResult AddSortItem(sortItem newItem)
        {
            MediaManagerDB items = new MediaManagerDB();
            items.sortItems.Add(newItem);
            items.SaveChanges();

            return RedirectToAction("GetContent");
        }

        /// <summary>
        /// Get the Show Listing or optionally pass a show to get season details
        /// </summary>
        /// <param name="id">pk_ShowID of the show to get info on</param>
        /// <returns>
        /// List view of all shows or show details if id provided
        /// </returns>
        public ActionResult ShowInfo(int? id)
        {
            MediaManagerDB db_shows = new MediaManagerDB();

            if (string.IsNullOrEmpty(id.ToString()))
            {

                return View(db_shows.TelevisionShows.OrderBy(show => show.ShowName));

            } else
            {

                return View(db_shows.TelevisionShows.Where(show => show.pk_ShowID.Equals(id)));

            }
        }

#endregion

    }
}