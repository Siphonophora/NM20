using System;

namespace NM2O_Spot_Analyzer
{
    public class SpotAnalysisUpdatedEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public SpotAnalysisUpdatedEventArgs(string arg)
        {
            Message = arg;
        }
    }
}