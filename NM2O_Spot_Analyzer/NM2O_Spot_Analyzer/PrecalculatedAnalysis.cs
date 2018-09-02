using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public static class PrecalculatedAnalysis
    {
        //public PrecalculatedAnalysis(string fileName)
        //{
        //    throw new NotImplementedException();
        //}

        public static double GetValue(string call, RadioInfo.BandName band)
        {
            Random random = new Random();
            return random.NextDouble();
        }

        public static List<PrecalculatedAnalysisRow> Data { get; private set; }
    }
}
