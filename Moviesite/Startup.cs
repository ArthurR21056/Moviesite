using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Moviesite.Startup))]
namespace Moviesite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
