using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSimpleAjax.Startup))]
namespace MVCSimpleAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
