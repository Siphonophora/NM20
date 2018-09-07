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
            if (Between(frequency, 1800d, 1900d))
            {
                return BandName.OneSixtyMeters;
            }
            else if (Between(frequency, 3500d, 3600d))
            {
                return BandName.EightyMeters;
            }
            else if (Between(frequency, 7000d, 7100d))
            {
                return BandName.FourtyMeters;
            }
            else if (Between(frequency, 14000d, 14100d))
            {
                return BandName.TwentyMeters;
            }
            else if (Between(frequency, 21000d, 21100d))
            {
                return BandName.FifteenMeters;
            }
            else if (Between(frequency, 28000d, 28100d))
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
