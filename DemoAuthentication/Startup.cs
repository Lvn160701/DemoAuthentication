using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAuthentication.Startup))]
namespace DemoAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
