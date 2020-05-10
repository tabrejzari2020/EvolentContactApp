using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvolentContactInfo.Startup))]
namespace EvolentContactInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
