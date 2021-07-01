using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Truck_Delivery_Tracking.Startup))]
namespace Truck_Delivery_Tracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
