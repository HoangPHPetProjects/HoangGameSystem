using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumberChoosing.Startup))]
namespace NumberChoosing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
