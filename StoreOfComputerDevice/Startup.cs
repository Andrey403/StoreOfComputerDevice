using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreOfComputerDevice.Startup))]
namespace StoreOfComputerDevice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
