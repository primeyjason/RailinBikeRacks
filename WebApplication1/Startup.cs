using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RailinBikeRacks.WEB.Startup))]
namespace RailinBikeRacks.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
