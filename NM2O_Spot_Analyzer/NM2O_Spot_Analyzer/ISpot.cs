using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace NM2O_Spot_Analyzer
{
    public interface ISpot
    {
        RadioInfo.BandName Band { get; set; }
        double Frequency { get; set; }
        string Call { get; set; }
        DateTimeOffset OffsetTimestamp { get; set; }
    }
}
