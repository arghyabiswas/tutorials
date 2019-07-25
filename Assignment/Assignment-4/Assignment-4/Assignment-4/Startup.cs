using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_4.Startup))]
namespace Assignment_4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
