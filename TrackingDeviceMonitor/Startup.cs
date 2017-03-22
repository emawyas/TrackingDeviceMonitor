using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackingDeviceMonitor.Startup))]
namespace TrackingDeviceMonitor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
