using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRTest.Startup))]

namespace SignalRTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            app.Map("/echo", map => map.RunSignalR<EchoConnection>());
        }
    }
}
