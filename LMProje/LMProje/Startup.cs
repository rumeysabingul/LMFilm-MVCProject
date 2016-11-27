using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMProje.Startup))]
namespace LMProje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
