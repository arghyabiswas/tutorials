using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignament12.Startup))]
namespace Assignament12
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
