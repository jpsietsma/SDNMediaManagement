using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SDNMediaModels.Account;
using SDNMediaModels.DBContext;
using SDNMediaModels.List;
using SDNMediaModels.Permission;

namespace MediaMaintenanceLibrary
{
    /// <summary>
    /// Class to handle creating default user security roles, users, and service accounts 
    /// </summary>
    public static class SecurityAuthorization
    {

        /// <summary>
        /// Create necessary permission levels to create default SDN Media Manager roles
        /// </summary>
        /// <param name="db">DBContext connection to SQL</param>
        /// <remarks>
        /// Please note: Users may be assigned multiple permission levels and roles, the least restrictive permission usually prevails.  
        /// I.E. If a user is in both the Guest and User roles, the user will have User Priviliges.  Please be aware and set permissions appropriately.
        /// </remarks>
        public static void CreateSDNPermissionLevels(MediaManagerDB db)
        {
            List<SDNPermissionLevel>defaultPermissions = new List<SDNPermissionLevel>();

            //Default Role: SuperAdmin - 
            defaultPermissions.Add(new SDNPermissionLevel { PermissionLevelNum = 0, PermissionLevelAuth = "SUPER", PermissionLevelDisplay = "SuperAdmin" });

            //Default Role: Administrator - Administrators to the SDN Media Manager system, have all access to config and content
            defaultPermissions.Add(new SDNPermissionLevel { PermissionLevelNum = 100, PermissionLevelAuth = "ADMIN", PermissionLevelDisplay = "Administrator" });

            //Default Role: Content Moderator - Users who have access to add and remove content in media libraries, but no access to any other administrative configurations
            defaultPermissions.Add(new SDNPermissionLevel { PermissionLevelNum = 150, PermissionLevelAuth = "CONMOD", PermissionLevelDisplay = "Content Moderator" });

            //Default Role: Content Contributor - Users who have been granted access to add content to media libraries, but not remove or acccess any other administrative configurations
            defaultPermissions.Add(new SDNPermissionLevel { PermissionLevelNum = 175, PermissionLevelAuth = "CONCONT", PermissionLevelDisplay = "Content Contributor" });

            //Default Role: System User - Normal system user, able to watch content in media libraries, and enter requests for media 
            defaultPermissions.Add(new SDNPermissionLevel { PermissionLevelNum = 200, PermissionLevelAuth = "USER", PermissionLevelDisplay = "System User" });

            //Default Role: System Gust - User who is able to test drive the look and feel of the SDN Media Manager layout, but not able to add, remove, or watch any content.  May prove useful for testing
            defaultPermissions.Add(new SDNPermissionLevel { PermissionLevelNum = 300, PermissionLevelAuth = "GUEST", PermissionLevelDisplay = "System Guest" });


            using (db)
            {
                List<list_permissionLevels> existing = db.list_permissionLevels.ToList();
                foreach (SDNPermissionLevel permission in defaultPermissions)
                {
                    if ((db.list_permissionLevels.SqlQuery($"SELECT count(permissionLevelAuth) FROM list_permissionLevels WHERE permissionLevelAuth = '{ permission.PermissionLevelAuth }' ").Count()) < 1)
                    {
                        try
                        {
                            db.list_permissionLevels.SqlQuery($"INSERT INTO list_permissionLevels ([pk_permissionLevelNum], [permissionLevelAuth], [permissionLevelDisplay]) VALUES ('{ permission.PermissionLevelNum }', '{ permission.PermissionLevelAuth }', '{ permission.PermissionLevelDisplay }') ");
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        
                    }
                    
                }                
            }

        }

        /// <summary>
        /// Create default SDN Media roles including Admin, Moderator, User, and Pending
        /// </summary>
        /// <param name="roleManager">RoleManager of type IdentityRole</param>
        public static void CreateSDNRoles(RoleManager<IdentityRole> roleManager)
        {

            //Check if out permission levels exist, create them if not
            CreateSDNPermissionLevels(new MediaManagerDB());

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

        /// <summary>
        /// Create default SDN user for initial setup
        /// </summary>
        /// <param name="db">MediaManagerDB Context</param>
        public static void CreateSDNUsers(MediaManagerDB db)
        {

            List<AspNetUser> users = db.AspNetUsers.ToList<AspNetUser>();

                users.Add(new AspNetUser { UserName = "setup", PasswordHash = "AH5XIgvyOVraK0OozwQC7wchNBbKHHhpboJgpSx2gD3ZbJgfuKZ1CJU69DcvJXDNHA==", Email = "--setup--", EmailConfirmed = false, AllowAccess = 2 });
                db.SaveChanges();
        }

    }
}
