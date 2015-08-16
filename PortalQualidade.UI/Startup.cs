using Microsoft.Owin;
using Owin;
using PortalQualidade.UI;

[assembly: OwinStartup(typeof(Startup))]
namespace PortalQualidade.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
