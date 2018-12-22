using Newtonsoft.Json;
using SDNetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SDNetAPI.Controllers
{
    [RoutePrefix("api/Movie")]
    public class MobileMovieController : ApiController
    {
        MobileLoginEntities db = new MobileLoginEntities();

        [HttpGet]
        [Route("GetMovieList")]
        //GET api/Login/GetMovieList
        public string GetMovies()
        {
            string finalJson = JsonConvert.SerializeObject(db.Movies.ToList());

            return finalJson;
        }
    }
}
