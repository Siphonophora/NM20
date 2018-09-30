using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public static class RadioInfo
    {
        public enum BandName { OneSixtyMeters, EightyMeters, FourtyMeters, TwentyMeters, FifteenMeters, TenMeters, None }

        public static BandName DetermineBand(double frequency)
        {
            if (Between(frequency, 1800d, 2400d))
            {
                return BandName.OneSixtyMeters;
            }
            else if (Between(frequency, 3500d, 4000d))
            {
                return BandName.EightyMeters;
            }
            else if (Between(frequency, 7000d, 7500d))
            {
                return BandName.FourtyMeters;
            }
            else if (Between(frequency, 14000d, 14500d))
            {
                return BandName.TwentyMeters;
            }
            else if (Between(frequency, 21000d, 21500d))
            {
                return BandName.FifteenMeters;
            }
            else if (Between(frequency, 28000d, 32000d))
            {
                return BandName.TenMeters;
            }

            return BandName.None;
        }

        private static bool Between(double d, double min, double max)
        {
            return (d >= min && d <= max);
        }

        public enum Mode { CW, RTTY, Unknown }

        public static Mode DetermineMode(string spotComment)
        {
            if (spotComment.StartsWith("CW"))
            {
                return Mode.CW;
            }
            else if (spotComment.StartsWith("RTTY"))
            {
                return Mode.RTTY;
            }
            return Mode.Unknown;
        }
    }
}
