using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace NM2O_Spot_Analyzer
{
    public class UDPServer
    {
        public event EventHandler<UDPMessageRecievedEventArgs> UDPMessageEvent;

        public void ServerThread()
        {

            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 12060);
            UdpClient newsock = new UdpClient(ipep);

            Console.WriteLine("Waiting for a client...");


            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);


            while (true)
            {
                data = newsock.Receive(ref sender);
                UDPMessageEvent?.Invoke(this, new UDPMessageRecievedEventArgs(Encoding.ASCII.GetString(data, 0, data.Length)));
                newsock.Send(data, data.Length, sender);
            }
        }
    }
}
