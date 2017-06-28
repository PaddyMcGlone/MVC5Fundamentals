using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Books.web.Startup))]
namespace Books.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
