using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_ASP.Startup))]
namespace Vidly_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
