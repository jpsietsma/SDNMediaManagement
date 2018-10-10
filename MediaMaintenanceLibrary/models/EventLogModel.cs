using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.models
{
    /// <summary>
    /// Represents a model to hold data for an entry read from the Windows Event Log
    /// </summary>
    public class EventLogModel
    {
        /// <summary>
        /// unique ID of EventLog object
        /// </summary>
        public int pk_EventID { get; set; }

        /// <summary>
        /// Type of event that occurred
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// Time that event occurred
        /// </summary>
        public DateTime EventTime { get; set; }

    }
}
