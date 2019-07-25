using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Index.Startup))]
namespace Index
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
