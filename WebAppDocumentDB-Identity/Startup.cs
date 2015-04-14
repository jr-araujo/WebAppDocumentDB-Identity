using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppDocumentDB_Identity.Startup))]
namespace WebAppDocumentDB_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
