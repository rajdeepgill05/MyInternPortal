using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyInternPortal.Startup))]
namespace MyInternPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
