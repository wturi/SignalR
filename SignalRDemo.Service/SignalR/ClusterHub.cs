using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Service.SignalR
{
    internal class ClusterHub:Hub<IClusterClient>
    {
        static ClusterHub()
        {
           var  aliveDictionary = new ConcurrentDictionary<string, Guid>();
        }

       
    }
}
