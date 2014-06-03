using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Faktura.Startup))]
namespace Faktura
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
