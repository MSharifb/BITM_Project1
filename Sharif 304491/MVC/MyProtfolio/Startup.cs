using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProtfolio.Startup))]
namespace MyProtfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
