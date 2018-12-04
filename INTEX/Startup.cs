using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INTEX.Startup))]
namespace INTEX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
