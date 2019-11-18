using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ventas.BackEnd.Startup))]
namespace Ventas.BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
