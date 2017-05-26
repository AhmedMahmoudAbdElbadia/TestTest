using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWithGithub.Startup))]
namespace TestWithGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
