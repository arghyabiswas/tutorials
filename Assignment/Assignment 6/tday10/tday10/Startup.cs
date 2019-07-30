using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tday10.Startup))]
namespace tday10
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
