using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PadukaBazarWebApp.Startup))]
namespace PadukaBazarWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
