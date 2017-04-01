using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(briggs50_Reviews.Startup))]
namespace briggs50_Reviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
