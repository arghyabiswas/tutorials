using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESSPLWebApplication.Startup))]
namespace ESSPLWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
