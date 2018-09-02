using System;
using System.IO;
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

        public static List<PrecalculatedAnalysisRow> Analysis { get; set; } = new List<PrecalculatedAnalysisRow>();
        
        public static void LoadAnalysis(string file)
        {
            Analysis.RemoveAll(x => x.Call != null);
            List<string> lines = File.ReadAllLines(file).ToList();

            foreach (var line in lines)
            {
                try
                {
                    Analysis.Add(new PrecalculatedAnalysisRow(line));
                }
                catch (Exception)
                {
                    //Skip on error
                }
            }

        }

        public static double GetValue(string call)
        {
            try
            {
                var r = Analysis.First(x => x.Call == call);
                return r.HoursWorked;
            }
            catch (Exception)
            {
                return 0;
            }
           
        }

        public static List<PrecalculatedAnalysisRow> Data { get; private set; }
    }
}
