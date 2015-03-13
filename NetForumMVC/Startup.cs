using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetForumMVC.Startup))]
namespace NetForumMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
