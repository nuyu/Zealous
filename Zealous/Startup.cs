using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zealous.Startup))]
namespace Zealous

{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
