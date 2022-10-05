using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3rdAssesment.Startup))]
namespace _3rdAssesment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
