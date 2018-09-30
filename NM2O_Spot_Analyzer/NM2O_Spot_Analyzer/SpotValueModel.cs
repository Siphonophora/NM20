using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallParser;

namespace NM2O_Spot_Analyzer
{
    public class SpotValueModel
    {

        public string Call { get; set; }
        public RadioInfo.BandName Band { get; set; }
        public ICountryZone CountryZone { get; set; }
        public int Multiplier { get; set; }
        public double CountryScarcity { get; set; }
        public double ZoneScarcity { get; set; }
        public double CZScarcity
        {
            get
            {
                if (Multiplier == 2)
                {
                    return CountryScarcity + ZoneScarcity;
                }
                else if (Multiplier == 1)
                {
                    return CountryScarcity;
                }
                return 0;//No mult, then it doesn't matter
            }
        }
        public double CallScarcity { get; set; }
        public double Value
        {
            get
            {
                if(Band == RadioInfo.BandName.None)
                {
                    return 0;
                }

                return (int)(CZScarcity + CallScarcity);
            }
        }

        public SpotValueModel(string call, ICountryZone countryZone, RadioInfo.BandName band, int multiplier)
        {
            Call = call;
            Band = band;
            CountryZone = countryZone;
            Multiplier = multiplier;
            CountryScarcity = Math.Log10((double)CZLabelBand("Totals", Band) / (CZLabelBand(CountryZone.Country, Band) + 1)); //Prevent divide by zero
            ZoneScarcity = Math.Log10((double)CZLabelBand("Totals", Band) / (CZLabelBand(CountryZone.CQZone.ToString(), Band) + 1));
            try
            {

                CallScarcity = (double)((PrecalculatedAnalysis.Call_Analysis.Where(x => x.Call == call).FirstOrDefault().HoursWorked * -1) + 24) / 6;
            }
            catch (Exception)
            {
                CallScarcity = 4;
            }

        }

        public int CZLabelBand(string label, RadioInfo.BandName band)
        {
            try
            {
                var o = PrecalculatedAnalysis.CountryZone_Analysis.Where(x => x.Label == label).First();

                if (band == RadioInfo.BandName.OneSixtyMeters)
                {
                    return o.OnePointEightMHz;
                }
                else if (band == RadioInfo.BandName.EightyMeters)
                {
                    return o.ThreePointFiveMHz;
                }
                else if (band == RadioInfo.BandName.FourtyMeters)
                {
                    return o.SevenMHz;
                }
                else if (band == RadioInfo.BandName.TwentyMeters)
                {
                    return o.FourteenMHz;
                }
                else if (band == RadioInfo.BandName.FifteenMeters)
                {
                    return o.TwentyOneMHz;
                }
                else if (band == RadioInfo.BandName.TenMeters)
                {
                    return o.TwentyEightMHz;
                }
                //Ignoring the null calse

                return 0;

            }
            catch (Exception)
            {
                return 0; //Missing case, maybe a country that wasn't in the last contest?
                throw;
            }
        }

        public override string ToString()
        {
            string s = $"Mult {Multiplier}, ";
            if (Multiplier == 2)
            {
                s += $"Zone Scarcity {ZoneScarcity.ToString("0.0")}, ";
            }
            if (Multiplier >= 1)
            {
                s += $"Country Scarcity {CountryScarcity.ToString("0.0")}, ";
            }

            s += $"Call Scarcity {CallScarcity.ToString("0.0")}";
            s += $" = Value {Value.ToString("0.0")}";
            return s;
        }
    }
}

