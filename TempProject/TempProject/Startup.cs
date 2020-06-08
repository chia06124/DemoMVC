using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempProject.Startup))]
namespace TempProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
