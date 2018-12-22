using Newtonsoft.Json;
using SDNetAPI.Models;
using SDNMediaModels.Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SDNetAPI.Controllers
{
    [RoutePrefix("api/Television")]
    public class MobileTelevisionController : ApiController
    {
        MobileLoginEntities db = new MobileLoginEntities();

        [HttpGet]
        [Route("GetShowList")]
        //GET api/Login/GetShowList
        public string GetShows()
        {
            var shows = db.TelevisionShows.ToList();
            var finalShows = new List<MobileShowResult>();

            foreach (TelevisionShow show in shows)
            {

                int.TryParse(show.ShowNumSeasons.ToString(), out int numSeasons);
                int.TryParse(show.ShowNumEpisodes.ToString(), out int numEpisodes);

                finalShows.Add(new MobileShowResult { ShowName = show.ShowName, NumSeasons = numSeasons, NumEpisodes = numEpisodes });
            }

            string finalJson = JsonConvert.SerializeObject(finalShows);

            return finalJson;
        }
        
    }
}
