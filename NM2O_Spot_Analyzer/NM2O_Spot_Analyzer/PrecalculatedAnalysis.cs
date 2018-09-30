using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallParser;
using Utility;

namespace NM2O_Spot_Analyzer
{
    public static class PrecalculatedAnalysis
    {

        public static List<CallAnalysis> Call_Analysis { get; set; } = new List<CallAnalysis>();
        public static List<CountryZoneAnalysis> CountryZone_Analysis { get; set; } = new List<CountryZoneAnalysis>();

        public static void LoadAnalysis(string callFile, string countryZoneFile)
        {
            Call_Analysis.RemoveAll(x => x.Call != null);
            List<string> callLines = File.ReadAllLines(callFile).ToList();

            foreach (var line in callLines)
            {
                try
                {
                    Call_Analysis.Add(new CallAnalysis(line));
                }
                catch (Exception)
                {
                    //Skip on error
                }
            }

            List<string> countryZoneLines = File.ReadAllLines(countryZoneFile).ToList();
            foreach (var line in countryZoneLines)
            {
                try
                {
                    CountryZone_Analysis.Add(new CountryZoneAnalysis(line));
                }
                catch (Exception)
                {
                    //Skip on error
                }
            }

        }

        public static List<CallAnalysis> Data { get; private set; }
    }
}
