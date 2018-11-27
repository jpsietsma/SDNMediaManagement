using SDNMediaModels.Account;
using SDNMediaModels.Television;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.Feedback
{
    
    /// <summary>
    /// Class to handle tracked television shows 
    /// </summary>
    public partial class TrackedShow
    {

        /// <summary>
        /// Primary key of tracking record
        /// </summary>
        public int pk_trackingID { get; set; }

        /// <summary>
        /// User ID of media user which tracked show
        /// </summary>
        public string fk_userID { get; set; }

        /// <summary>
        /// Show ID of tracked show
        /// </summary>
        public int fk_showID { get; set; }

        /// <summary>
        /// Users which tracked shows
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; }

        /// <summary>
        /// Shows which are tracked by users
        /// </summary>
        public virtual TelevisionShow TelevisionShow { get; set; }
    }
}
