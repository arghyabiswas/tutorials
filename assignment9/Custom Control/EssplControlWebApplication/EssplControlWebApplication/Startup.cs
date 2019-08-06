using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EssplControlWebApplication.Startup))]
namespace EssplControlWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
