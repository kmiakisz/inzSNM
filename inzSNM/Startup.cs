using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(inzSNM.Startup))]
namespace inzSNM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
