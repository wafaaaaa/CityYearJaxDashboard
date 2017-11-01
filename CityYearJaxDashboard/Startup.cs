using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CityYearJaxDashboard.Startup))]
namespace CityYearJaxDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
