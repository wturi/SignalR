using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDemo.Service
{
   public  interface IChatClient
    {
        void Broadcast(string name, string message);
    }
}
