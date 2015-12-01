using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalPortfolio3.Startup))]
namespace FinalPortfolio3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
