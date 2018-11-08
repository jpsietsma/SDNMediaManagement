using SDNMediaModels.List;
using System;
using System.Collections.Generic;
	
namespace SDNMediaModels.Account
{
    
    public partial class AspNetRole : IAspNetRole
    {

        public AspNetRole()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public int fk_PermissionLevelNum { get; set; }
    
        public virtual list_permissionLevels list_permissionLevels { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
