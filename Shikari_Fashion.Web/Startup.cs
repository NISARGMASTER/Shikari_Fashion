using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shikari_Fashion.Web.Startup))]
namespace Shikari_Fashion.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
