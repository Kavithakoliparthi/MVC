using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAplication.Startup))]
namespace MVCAplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
