using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(linqcrud.Startup))]
namespace linqcrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
