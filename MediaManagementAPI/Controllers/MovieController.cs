using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediaManagementAPI.Controllers
{
    
    /// <summary>
    /// Manipulate and retrieve data from Movies in the database.
    /// </summary>
    public class MovieController : ApiController
    {
        // GET: api/Movie
        /// <summary>
        /// Get list of Movies in the live folders
        /// </summary>
        /// <returns>List of movie titles</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
