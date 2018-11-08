using SDNMediaModels.Account;
using System;
using System.Collections.Generic;

namespace SDNMediaModels.List
{  
    
    public partial class list_permissionLevels
    {

        public list_permissionLevels()
        {
            this.AspNetRoles = new HashSet<AspNetRole>();
        }
    
        public int pk_permissionLevelNum { get; set; }
        public string permissionLevelAuth { get; set; }
        public string permissionLevelDisplay { get; set; }
    
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
