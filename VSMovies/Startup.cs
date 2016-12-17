using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSMovies.Startup))]
namespace VSMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
