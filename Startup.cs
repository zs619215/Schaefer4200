using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Schaefer4200.Startup))]
namespace Schaefer4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
