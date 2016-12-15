using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicBathWebApp.Startup))]
namespace MusicBathWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
