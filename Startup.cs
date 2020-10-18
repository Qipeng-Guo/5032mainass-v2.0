using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5032mainass_v2._0.Startup))]
namespace _5032mainass_v2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
