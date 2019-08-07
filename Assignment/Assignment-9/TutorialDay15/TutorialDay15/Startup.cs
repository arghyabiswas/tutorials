using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialDay15.Startup))]
namespace TutorialDay15
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
