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
        }
    }
}