using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finra.Web.Startup))]
namespace Finra.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
