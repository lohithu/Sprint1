using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sprint1_testing.Startup))]
namespace sprint1_testing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
