using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace SignalRDemo.Client
{
     static class Program
    {
        static void Main(string[] args)
        {
           Get();
        }

         static void Get()
        {
            var url = "http://localhost:10086/";
            var connection=new HubConnection(url);
            var chatHub = connection.CreateHubProxy("ChatHub");
            connection.Start().ContinueWith(item =>
            {
                if (item.IsFaulted)
                {
                    Console.WriteLine("连接故障1");
                }
            });
            var broadcastHandler = chatHub.On<string, string>("broadcast", (name, message) =>
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]{name}：{message}");
            });

            Console.WriteLine("请输入你的昵称：");
            var _name = Console.ReadLine();
            Console.WriteLine("开始聊天！");
            while (true)
            {
                var _message = Console.ReadLine();
                chatHub.Invoke("Send", _name, _message).ContinueWith(item =>
                {
                    if (item.IsFaulted)
                    {
                        Console.WriteLine("连接故障2");
                    }
                });
            }
        }
    }
}
