using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NM2O_Spot_Analyzer;

namespace StaticAnalyzer
{
    class Program
    {
        static void Main(string[] args)
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

            File.WriteAllLines(@"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2017cw\analysis.csv", analysis.ToArray());
            Console.ReadLine();
        }
    }
}
