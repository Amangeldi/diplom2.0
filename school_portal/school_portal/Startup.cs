using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(school_portal.Startup))]
namespace school_portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
