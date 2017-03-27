using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRDemo.Service.SignalR
{
    public class ChatHub : Hub<IChatClient>
    {
        public void Send(string name, string message)
        {
            Console.WriteLine($"ConnectionId:{Context.ConnectionId}，{name}：{message}");
            Clients.AllExcept(Context.ConnectionId).Broadcast(name,message);
        }
    }
}
