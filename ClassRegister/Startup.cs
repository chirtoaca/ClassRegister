using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassRegister.Startup))]
namespace ClassRegister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
