using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment_5.Startup))]
namespace assignment_5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
