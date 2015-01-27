using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwankyJanes_v01._01.Startup))]
namespace SwankyJanes_v01._01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
