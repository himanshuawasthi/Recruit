using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recruit.Startup))]
namespace Recruit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
