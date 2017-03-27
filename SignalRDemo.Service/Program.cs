using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace SignalRDemo.Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string url = "http://localhost:10086";
            WebApp.Start<Starup>(url);
            Console.WriteLine($"服务器开启，连接地址是： {url}");
            Console.ReadLine();
        }
    }
}
