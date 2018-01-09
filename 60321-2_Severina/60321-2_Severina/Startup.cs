using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_60321_2_Severina.Startup))]
namespace _60321_2_Severina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
