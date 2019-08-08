using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutosExchange.Startup))]
namespace AutosExchange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
