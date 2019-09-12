using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Miffen.WebUI.Startup))]
namespace Miffen.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
