using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalFinal.Startup))]
namespace FinalFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
