using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplication1.App_Start.Startup))]

namespace WebApplication1.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //注册管道，使用默认的虚拟地址，根目录下的"/signalr"，当然你也可以自己定义
            app.MapSignalR();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
