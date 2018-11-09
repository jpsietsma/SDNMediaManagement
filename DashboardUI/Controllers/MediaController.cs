
using Kendo.Mvc.Extensions;
using SDNMediaModels.DBContext;
using SDNMediaModels.Sort;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DashboardUI.Controllers
{
    [Authorize]
    public class MediaController : Controller
    {

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
            MediaManagerDB db = new MediaManagerDB();

            return View(db.TelevisionSeasons.Where(s => s.fk_ShowID == id).ToList<TelevisionSeason>());

        }

        //Plays season with episodes populated in playlist
        public ActionResult WatchSeason(int id)
        {
            MediaManagerDB db_episodes = new MediaManagerDB();
            List<TelevisionEpisode> episodes = db_episodes.TelevisionEpisodes.Where(e => e.fk_SeasonID == id).Where(e => e.IsEnabled.Equals(1)).ToList<TelevisionEpisode>();

            return PartialView("_WatchSeason", episodes);
        }

        //Show view to create new season
        public ActionResult AddSeason(int id)
        {
            MediaManagerDB shows_db = new MediaManagerDB();
            TelevisionShow show = shows_db.TelevisionShows.Where(showDetails => showDetails.pk_ShowID == id).FirstOrDefault();

            return View(show);
        }

        //Add new season model created and save changes to database, redirect to seasons listing of parent show
        public ActionResult SaveSeason(TelevisionSeason newSeason)
        {
            //SietsmaDevMediaModel db = new SietsmaDevMediaModel();
            //seasons.SaveChanges();

            return RedirectToAction("SeasonInfo", new { id = newSeason.fk_ShowID });
        }

#endregion

#region Show Actions / Views...

        /// <summary>
        /// Create new Television Show
        /// </summary>
        /// <returns>
        /// Form for entering new show details
        /// </returns>
        public ActionResult CreateShow()
        {
            return View(new TelevisionShow { ShowAlbumArtPath = "~art", IsEnabled = true, ShowNumSeasons = 0, ShowNumEpisodes = 0, fk_MediaType = 8 });
        }

        /// <summary>
        /// Save new Television Show to the database
        /// </summary>
        /// <param name="televisionShow">TelevisionShow entity to add to the database</param>
        /// <returns>
        /// Show Listing of Seasons
        /// </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateShow([Bind(Include = "ShowName,ShowDriveLetter,ShowHomePath,ShowNumSeasons,ShowNumEpisodes,ShowAlbumArtPath,IsEnabled,TvdbID,ImdbID,fk_MediaType")] TelevisionShow televisionShow)
        {
            MediaManagerDB db = new MediaManagerDB();
                        
            if (ModelState.IsValid)
            {
                televisionShow.ShowAlbumArtPath = televisionShow.ShowAlbumArtPath.Replace("~art", televisionShow.ShowHomePath + @"\art");
                televisionShow.ShowNumSeasons = 0;
                televisionShow.ShowNumEpisodes = 0;
                televisionShow.ShowDriveLetter = televisionShow.ShowHomePath[0].ToString();

                db.TelevisionShows.Add(televisionShow);
                db.SaveChanges();

                //var showID = db.TelevisionShows.Where(s => s.ShowName == televisionShow.ShowName).First().pk_ShowID;

                int.TryParse(db.GetShowIdByName(televisionShow.ShowName, null).ToString(), out int showID);

                return RedirectToAction("SeasonInfo", "Media", db.TelevisionSeasons.Where(s => s.fk_ShowID == showID).ToList());
            }
            return View(televisionShow);
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


#region Movie Actions / Views...

        //This is where Movie related actions will go

#endregion

#region Sort Actions / Views...

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

#endregion

#region Navigation Actions/Views...

        //header nav and show search autocomplete related code will go here

#endregion

    }
}