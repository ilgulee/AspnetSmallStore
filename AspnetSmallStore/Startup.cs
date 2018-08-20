using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetSmallStore.Startup))]
namespace AspnetSmallStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
