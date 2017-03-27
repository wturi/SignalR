using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDemo.Service
{
    public interface IChatHub
    {
        void Send(string name, string message);
    }
}
