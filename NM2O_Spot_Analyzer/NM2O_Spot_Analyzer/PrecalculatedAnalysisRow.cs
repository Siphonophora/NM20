using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public class PrecalculatedAnalysisRow
    {
        public PrecalculatedAnalysisRow(string call, float value)
        {
            Call = call;
            Value = value;
        

      
        }

        public string Call { get; private set; }
        public float Value { get; private set; }
    }
}
