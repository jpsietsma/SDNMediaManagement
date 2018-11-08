using System;
using System.Collections.Generic;

namespace SDNMediaModels.Account
{
        
    public partial class AspNetUserLogin : IAspNetUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
