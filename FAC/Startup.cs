using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FAC.Startup))]
namespace FAC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
