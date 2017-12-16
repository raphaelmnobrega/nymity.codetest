using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nymity.codetest.web.Startup))]
namespace nymity.codetest.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
