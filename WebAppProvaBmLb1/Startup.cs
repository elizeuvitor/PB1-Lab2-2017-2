using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProvaBmLb1.Startup))]
namespace WebAppProvaBmLb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
