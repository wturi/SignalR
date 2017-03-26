using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApplication1.SignalR
{
    [HubName("tableAService")]
    public class TableAHub : Hub
    {
        [HubMethodName("show")]
        public static void Show()
        {
            IHubContext contentext = GlobalHost.ConnectionManager.GetHubContext<TableAHub>();

            contentext.Clients.All.displayDatas();
        }
    }
}