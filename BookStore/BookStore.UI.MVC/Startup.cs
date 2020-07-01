using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore.UI.MVC.Startup))]
namespace BookStore.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
