using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(briggs_Reviews.Startup))]
namespace briggs_Reviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
