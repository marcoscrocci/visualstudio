using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebGearHost.Startup))]
namespace WebGearHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
