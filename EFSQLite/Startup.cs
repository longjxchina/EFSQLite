using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFSQLite.Startup))]
namespace EFSQLite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
