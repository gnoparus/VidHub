using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidHub.Startup))]
namespace VidHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
