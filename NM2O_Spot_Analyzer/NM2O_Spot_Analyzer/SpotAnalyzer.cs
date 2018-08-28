using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public class SpotAnalyzer
    {
        public event EventHandler<SpotAnalysisUpdatedEventArgs> BufferUpdate;

        public string Buffer { get; private set; }

        public void ParseMessage(string test)
        {




            Buffer += test;
            BufferUpdate?.Invoke(this, new SpotAnalysisUpdatedEventArgs(Buffer));
        }
    }
}
