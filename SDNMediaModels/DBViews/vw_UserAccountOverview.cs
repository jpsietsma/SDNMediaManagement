using System;
using System.Collections.Generic;

namespace SDNMediaModels.DBViews
{    

    /// <summary>
    /// View giving permissions overview of all system accounts
    /// </summary>
    public partial class vw_UserAccountOverview
    {

        /// <summary>
        /// Login user name associated with user account
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email addres associated with user account
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Name of Role granted to user account
        /// </summary>
        public string Name { get; set; }
    }
}
