using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASTEK.Architecture.UI.MVC.Startup))]
namespace ASTEK.Architecture.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
