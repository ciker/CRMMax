using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRMAX.Web.Startup))]
namespace CRMAX.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
