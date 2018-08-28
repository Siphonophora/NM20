using System;

using System.Text;

namespace UDPServer
{
    public static class UDPServerProgram
    {
        public static UDPServer Server { get; set; }

        static void Main(string[] args)
        {
            Server = new UDPServer();
            Server.Run();
        }
    }
}
