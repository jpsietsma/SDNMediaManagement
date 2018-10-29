using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MediaMaintenanceLibrary
{
    /// <summary>
    /// Class to handle creating default user security roles, users, and service accounts 
    /// </summary>
    public static class SecurityAuthorization
    {

        /// <summary>
        /// Create default SDN Media roles including Admin, Moderator, User, and Pending
        /// </summary>
        /// <param name="roleManager">RoleManager of type IdentityRole</param>
        public static void CreateSDNRoles(RoleManager<IdentityRole> roleManager)
        {

            //If the admin role hasnt been created, create it.
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

            }

            //If the user role hasnt been created, create it.
            if (!roleManager.RoleExists("user"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);


            }

            //If the moderator role hasnt been created, create it.
            if (!roleManager.RoleExists("moderator"))
            {
                var role = new IdentityRole();
                role.Name = "Moderator";
                roleManager.Create(role);
            }

            //If the pending role hasnt been created, create it.
            if (!roleManager.RoleExists("pending"))
            {
                var role = new IdentityRole();
                role.Name = "Pending";
                roleManager.Create(role);
            }
        }
    }
}
