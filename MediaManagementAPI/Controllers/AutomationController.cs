using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MediaManagementAPI.Controllers
{
    /// <summary>
    /// Manually launch automation processes using these calls.
    /// </summary>
    public class AutomationController : ApiController
    {
        // GET: api/Automation
        /// <summary>
        /// Retrieve current queue of automation tasks awaiting processing
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetTasks()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Automation
        /// <summary>
        /// Create a new Television Show
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        // DELETE: api/Automation/5
        /// <summary>
        /// Delete a task from the automation queue.
        /// </summary>
        /// <param name="id">ID of task to delete</param>
        public void DeleteTask(int id)
        {
        }
    }
}
