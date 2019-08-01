using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignmnet8.Startup))]
namespace Assignmnet8
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
