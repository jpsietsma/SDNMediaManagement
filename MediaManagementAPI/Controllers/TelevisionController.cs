using MediaManagementAPI.Models;
using SDNMediaModels.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediaManagementAPI.Controllers
{
    /// <summary>
    /// Manipulate and retrieve data from Television shows in the database.
    /// </summary>
    public class TelevisionController : ApiController
    {
        MediaManagerDB db = new MediaManagerDB();
        List<TVShow> shows = new List<TVShow>();

        public TelevisionController()
        {
            shows.Add(new TVShow { ShowName = "Test Show 1"});
            shows.Add(new TVShow { ShowName = "Adventures of Test" });
            shows.Add(new TVShow { ShowName = "Patrol - Test Away on the Beat" });
        }

        // GET: api/Television
       /// <summary>
       ///     Get list of Television Shows in live folders.
       /// </summary>
       /// <returns>
       ///     List of show names
       /// </returns> 
        public List<string> Get()
        {
            List<string> finalNames = new List<string>();

            foreach (TVShow show in shows)
            {
                finalNames.Add(show.ShowName);
            }

            return finalNames;
        }

    }
}
