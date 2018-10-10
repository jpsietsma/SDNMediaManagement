using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMaintenanceLibrary.enums
{

    /// <summary>
    /// Represents the priorities of importance in which the automation will process tasks
    /// </summary>
    public enum AutomationTaskPriorityOptions
    {
        /// <summary>
        /// Task has been completed, automation will ignore, cannot be resumed as task is complete.
        /// </summary>
        COMPLETED = 101,

        /// <summary>
        /// Will not be completed, automation will ignore, cannot be resumed by user
        /// </summary>
        CANCELLED = 0,

        /// <summary>
        /// Has been paused, automation will ignore, task can be resumed by user
        /// </summary>
        PAUSED = 10,

        /// <summary>
        /// Item is not a type that the automation recognizes, automation will ignore, can be manually identified by user
        /// </summary>
        IGNORED = -1,

        /// <summary>
        /// Low priority items i.e. Sort junk cleanup, library scheduled maintenance, metadata retrieval
        /// </summary>
        LOW = 20,

        /// <summary>
        /// Medium priority items i.e. File Type/Name Sort Sanitization, Default priority for most user initiated-tasks
        /// </summary>
        MEDIUM = 90,

        /// <summary>
        /// High Priority items i.e. Storage space tasks, media move tasks, Can be used for user-initiated tasks
        /// </summary>
        HIGH = 90,

        /// <summary>
        /// Pauses the current task in automation to process anything SUPER_HIGH priority, can only be initiated from an exception occurring or automation missing files
        /// </summary>
        SUPER_HIGH = 100

    }
}
