using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LY.MVCOA.Project.Startup))]
namespace LY.MVCOA.Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
