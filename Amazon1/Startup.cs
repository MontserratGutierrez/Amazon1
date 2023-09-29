using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Amazon1.Startup))]
namespace Amazon1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
