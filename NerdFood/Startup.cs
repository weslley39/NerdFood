using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NerdFood.Startup))]
namespace NerdFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
