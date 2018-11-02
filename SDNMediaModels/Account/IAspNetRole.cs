using System.Collections.Generic;
using SDNMediaModels.List;

namespace SDNMediaModels.Account
{
    public interface IAspNetRole
    {
        ICollection<AspNetUser> AspNetUsers { get; set; }
        int fk_PermissionLevelNum { get; set; }
        string Id { get; set; }
        list_permissionLevels list_permissionLevels { get; set; }
        string Name { get; set; }
    }
}