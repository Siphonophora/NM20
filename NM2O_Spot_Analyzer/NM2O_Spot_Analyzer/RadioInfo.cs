using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public static class RadioInfo
    {
        public enum BandName { OnePointEightMHz, ThreePointFiveMHz, SevenMHz, FourteenMHz, TwentyOneMHz, TwentyEightMHz, None }

        public static BandName DetermineBand(double frequency)
        {
            if (Between(frequency, 500d, 2500d))
            {
                return BandName.OnePointEightMHz;
            }
            else if (Between(frequency, 2600d, 5000d))
            {
                return BandName.ThreePointFiveMHz;
            }
            else if (Between(frequency, 5000d, 10000d))
            {
                return BandName.SevenMHz;
            }
            else if (Between(frequency, 11000d, 17000d))
            {
                return BandName.FourteenMHz;
            }
            else if (Between(frequency, 18000d, 24000d))
            {
                return BandName.TwentyOneMHz;
            }
            else if (Between(frequency, 25000d, 32000d))
            {
                return BandName.TwentyEightMHz;
            }
            else

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
