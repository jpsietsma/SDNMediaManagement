using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediaManagementAPI.Controllers
{

    /// <summary>
    /// Manipulate downloaded files in the sort folder that are awaiting processing.
    /// </summary>
    public class SortController : ApiController
    {
        // GET: api/Sort
        /// <summary>
        /// Get a list of files sitting in the sort drive.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sort/5
        /// <summary>
        /// Get details about a specific file sitting in the sort queue.
        /// </summary>
        /// <param name="id">Id of the file to retrieve information on.</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // DELETE: api/Sort/5
        /// <summary>
        /// Delete downloaded file from the sort queue.  THIS CANNOT BE UNDONE!
        /// </summary>
        /// <param name="id">Id of the file to delete.</param>
        public void Delete(int id)
        {
        }
    }
}
