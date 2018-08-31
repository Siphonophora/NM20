using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public class UDPServerThread
    {
        public UDPServer Server { get; private set; }
        public Thread Thread { get; private set; }

        public UDPServerThread()
        {
            Server = new UDPServer();
            Thread = new Thread(new ThreadStart(Server.ServerThread));
            Thread.Start();
        }
    }
}
