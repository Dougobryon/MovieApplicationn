using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieApplicationn.Startup))]
namespace MovieApplicationn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
