using DashboardUI.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    [Authorize]
    public class MediaController : Controller
    {

#region Episode Action / Views...

        public ActionResult WatchEpisode(int id)
        {
            TelevisionEpisodeItem db_episodes = new TelevisionEpisodeItem();

            var model = db_episodes.sdnTelevisionEpisodes.Where(x => x.pk_EpisodeID == id).Where(episode => episode.IsEnabled.Equals(1)).First();
            return PartialView("_WatchEpisode", model);
        }

        public ActionResult EditEpisodeDetails(int id)
        {
            TelevisionEpisodeItem db_episodes = new TelevisionEpisodeItem();

            var model = db_episodes.sdnTelevisionEpisodes.Where(e => e.pk_EpisodeID == id).Where(episode => episode.IsEnabled.Equals(1)).First();
            return PartialView("_EditEpisode", model);
        }

        public ActionResult EpisodeDetails(int id)
        {
            TelevisionEpisodeItem db_episodes = new TelevisionEpisodeItem();

            return View(db_episodes.sdnTelevisionEpisodes.Where(e => e.pk_EpisodeID == id).Where(episode => episode.IsEnabled.Equals(1)).First());
        }

        public ActionResult EpisodeInfo(int id)
        {
            TelevisionEpisodeItem db_episodes = new TelevisionEpisodeItem();

            return View(db_episodes.sdnTelevisionEpisodes.Where(episodes => episodes.fk_SeasonID == id).OrderBy(o => o.EpisodeNum).Where(episode => episode.IsEnabled.Equals(1)));
        }

#endregion

#region Season Actions / Views...

        //Lists all seasons of the show who's id is passed
        public ActionResult SeasonInfo(int id)
        {
            TelevisionSeasonItem db_seasons = new TelevisionSeasonItem();

            return View(db_seasons.sdnTelevisionSeasons.Where(season => season.fk_ShowID.Equals(id)).Where(season => season.IsEnabled.Equals(1)));

        }

        //Plays season with episodes populated in playlist
        public ActionResult WatchSeason(int id)
        {
            TelevisionEpisodeItem db_episodes = new TelevisionEpisodeItem();
            List<TelevisionEpisodeModel> episodes = db_episodes.sdnTelevisionEpisodes.Where(e => e.fk_SeasonID == id).Where(e => e.IsEnabled.Equals(1)).ToList<TelevisionEpisodeModel>();

            return PartialView("_WatchSeason", episodes);
        }

        //Show view to create new season
        public ActionResult AddSeason()
        {
            return View();
        }

        //Add new season model created and save changes to database, redirect to seasons listing of parent show
        public ActionResult SaveSeason(TelevisionSeasonModel newSeason)
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
        /// <param name="newShow">TelevisionShowModel representing show to be added</param>
        /// <returns>redirect to list of shows when successful</returns>
        public ActionResult AddShow(TelevisionShowModel newShow)
        {
            TelevisionShowItem shows = new TelevisionShowItem();

            shows.sdnTelevisionShows.Add(newShow);
            shows.SaveChanges();

            return RedirectToAction("ShowInfo");

        }

        /// <summary>
        /// Displays view with form for adding new sort item to the database
        /// </summary>
        /// <returns>form for adding a new sort item</returns>
        public ActionResult AddSortItem()
        {
            SortMediaItem items = new SortMediaItem();

            return View();
        }

        /// <summary>
        /// Action to add sort item to the database
        /// </summary>
        /// <param name="newItem">SortMediaItemModel representing the new item to add to the database</param>
        /// <returns>
        /// redirect to view displaying kendoui grid with all sort items
        /// </returns>
        public ActionResult AddSortItem(SortMediaItemModel newItem)
        {
            SortMediaItem items = new SortMediaItem();
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
            TelevisionShowItem db_shows = new TelevisionShowItem();

            if (string.IsNullOrEmpty(id.ToString()))
            {

                return View(db_shows.sdnTelevisionShows.OrderBy(show => show.ShowName));

            } else
            {

                return View(db_shows.sdnTelevisionShows.Where(show => show.pk_ShowID.Equals(id)));

            }
        }

#endregion

    }
}