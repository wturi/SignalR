using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Service.SignalR
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Console.WriteLine($"ConnectionId:{Context.ConnectionId}，{name}发送：{message}");
            Clients.AllExcept(Context.ConnectionId).broadcast(name, message);
        }

    }
}
