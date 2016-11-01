using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGitProject.Startup))]
namespace MVCGitProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
