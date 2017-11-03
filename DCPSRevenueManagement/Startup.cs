using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DCPSRevenueManagement.Startup))]
namespace DCPSRevenueManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
