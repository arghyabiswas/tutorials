using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialDay17.Startup))]
namespace TutorialDay17
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
