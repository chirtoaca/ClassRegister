using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassRegister.Web.Startup))]
namespace ClassRegister.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
