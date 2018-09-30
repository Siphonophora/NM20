using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NM2O_Spot_Analyzer;
using CallParser;
using Utility;

namespace StaticAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunCallAnalysis();
            RunCountryZoneAnalysis();

            Console.WriteLine("Done");
        }

        static void RunCallAnalysis()
        {

            List<string> files = Directory.GetFiles(@"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2017cw\CSV\Submitted").ToList();
            files.AddRange(Directory.GetFiles(@"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2017cw\CSV\Virtual").ToList());
            List<string> analysis = new List<string>();
            string header = "Call,TotalHours";
            foreach (var item in Enum.GetValues(typeof(RadioInfo.BandName)))
            {
                header += $",{item}";
            }
            analysis.Add(header);


            foreach (string file in files)
            {
                List<QSO> qsos = new List<QSO>();

                List<string> lines = File.ReadAllLines(file).ToList();
                for (int i = 1; i < lines.Count; i++)
                {
                    qsos.Add(new QSO(lines[i]));
                }



                var o = qsos.GroupBy(x => x.DateHour).Count();
                var totalHours = o > 48 ? 48 : o;

                var b = qsos.GroupBy(x => x.Band)
                    .Select(y => new
                    {
                        Band = y.Key,
                        Count = y.Select(x => x.DateHour).Distinct().Count()
                    });

                string s = "";
                foreach (var item in Enum.GetValues(typeof(RadioInfo.BandName)))
                {
                    try
                    {
                        var c = b.First(x => x.Band == (RadioInfo.BandName)item);
                        s += $"{(c.Count > 48 ? 48 : c.Count).ToString()},";
                    }
                    catch (Exception)
                    {
                        s += $"0,";
                    }
                }

                string summary = $"{qsos[0].SentCall},{totalHours},{s.Substring(0, s.Length - 1)}";
                analysis.Add(summary);
                Console.WriteLine(summary);
            }

            File.WriteAllLines(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\NM2O_Spot_Analyzer\Call_Analysis.csv", analysis.ToArray());
        }

        static void RunCountryZoneAnalysis()
        {
            List<string> callAnalysis = File.ReadAllLines(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\NM2O_Spot_Analyzer\Call_Analysis.csv").ToList();
            CountryParser parser = new CountryParser(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\NM2O_Spot_Analyzer\bin\Debug\N1MM_CountryList.dat");
            List<CountryZoneAnalysis> analyses = new List<CountryZoneAnalysis>();

            foreach (var call in callAnalysis)
            {
                string[] callinfo = call.Split(',');

                try
                {
                    var parsed = parser.CheckCall(callinfo[0]);

                    if (!analyses.Exists(x => x.Label == parsed.Country))
                    {
                        analyses.Add(new CountryZoneAnalysis(parsed.Country, call, CountryZoneAnalysis.Type.Country));
                    }
                    else
                    {
                        //var a = analyses.Where(x => x.Label == parsed.Country);
                        analyses.Where(x => x.Label == parsed.Country).First().Add(call);
                    }

                    if (!analyses.Exists(x => x.Label == parsed.CQZone.ToString()))
                    {
                        analyses.Add(new CountryZoneAnalysis(parsed.CQZone.ToString(), call, CountryZoneAnalysis.Type.Zone));
                    }
                    else
                    {
                        analyses.Where(x => x.Label == parsed.CQZone.ToString()).First().Add(call);
                    }
                    //Console.WriteLine($"{callinfo[0]} from {parsed.Country} zone {parsed.CQZone}");

                }
                catch (Exception)
                {
                    Console.WriteLine($"Unable to parse {callinfo[0]}");

                }
            }

            var o = analyses.GroupBy(x => x.CZType)
                            .Select(t => new
                            {
                                CZType = t.Key,
                                TotalHours = t.Sum(x => x.TotalHours),
                                OnePointEightMHz = t.Sum(x => x.OnePointEightMHz),
                                ThreePointFiveMHz = t.Sum(x => x.ThreePointFiveMHz),
                                SevenMHz = t.Sum(x => x.SevenMHz),
                                FourteenMHz = t.Sum(x => x.FourteenMHz),
                                TwentyOneMHz = t.Sum(x => x.TwentyOneMHz),
                                TwentyEightMHz = t.Sum(x => x.TwentyEightMHz),
                                None = t.Sum(x => x.None),
                            })
                            .First(); //We only need one, because they will always be equal.  

            List<string> filecontents = new List<string>() { "CZType,Label,TotalHours,OnePointEightMHz,ThreePointFiveMHz,SevenMHz,FourteenMHz,TwentyOneMHz,TwentyEightMHz,None" };
            filecontents.Add($"Totals,Totals,{o.TotalHours},{o.OnePointEightMHz},{o.ThreePointFiveMHz},{o.SevenMHz},{o.FourteenMHz},{o.TwentyOneMHz},{o.TwentyEightMHz},{o.None}");
            foreach (var item in analyses.OrderBy(x => x.ToString()))
            {
                filecontents.Add(item.ToString());
            }

            File.WriteAllLines(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\NM2O_Spot_Analyzer\CountryZone_Analysis.csv", filecontents.ToArray());
        }
    }
}
