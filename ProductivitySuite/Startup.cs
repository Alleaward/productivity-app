using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductivitySuite.Startup))]
namespace ProductivitySuite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
