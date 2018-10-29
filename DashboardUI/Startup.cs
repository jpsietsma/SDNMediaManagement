using MediaMaintenanceLibrary;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashboardUI.Startup))]

namespace DashboardUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            IdentityDbContext db = new IdentityDbContext();

            //create our role and user managers
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(db));

            //Create default SDN Media roles
            SecurityAuthorization.CreateSDNRoles(roleManager);
        }
       
    }
}