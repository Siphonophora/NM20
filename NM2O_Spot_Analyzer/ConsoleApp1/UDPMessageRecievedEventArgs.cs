using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPServer
{
    public class UDPMessageRecievedEventArgs : EventArgs
    {
        public UDPMessageRecievedEventArgs(string message)
        {
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public string Message { get; private set; }
    }
}
