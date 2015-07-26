using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuEntradaVirtual.Startup))]
namespace TuEntradaVirtual
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
