using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.enums
{
    /// <summary>
    /// Statuses for automation tasks in the work queue
    /// </summary>
    public enum AutomationStatusOptions
    {

        /// <summary>
        /// Task has been completed successfully
        /// </summary>
        COMPLETED,

        /// <summary>
        /// Task has encountered an error and has not been completed
        /// </summary>
        ERROR,

        /// <summary>
        /// Task is Waiting for user action and has not been completed
        /// </summary>
        WAITING_ON_USER,

        /// <summary>
        /// Task has been stopped by the user
        /// </summary>
        STOPPED,

        /// <summary>
        /// User has elected to skip the task
        /// </summary>
        SKIPPED,

        /// <summary>
        /// Automation is working on the task
        /// </summary>
        IN_PROGRESS,

        /// <summary>
        /// This task is set to be completed next
        /// </summary>
        PENDING,

        /// <summary>
        /// Task is in the queue to be addressed
        /// </summary>
        QUEUED

    }
}
