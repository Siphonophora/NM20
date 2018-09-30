using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public class CallAnalysis
    {
        public CallAnalysis(string call, double hoursworked)
        {
            Call = call;
            HoursWorked = hoursworked;
        }

        public CallAnalysis(string row)
        {
            string[] data = row.Split(',');

            Call = data[0];
            HoursWorked = double.Parse(data[1]);
        }

        public string Call { get; private set; }
        public double HoursWorked { get; private set; }
    }
}
