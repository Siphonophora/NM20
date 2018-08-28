using System;

namespace NM2O_Spot_Analyzer
{
    public class UDPMessageRecievedEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public UDPMessageRecievedEventArgs(string arg)
        {
            Message = arg;
        }
    }
}