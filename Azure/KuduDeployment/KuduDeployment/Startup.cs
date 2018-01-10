using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KuduDeployment.Startup))]
namespace KuduDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
