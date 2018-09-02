using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NM2O_Spot_Analyzer;

namespace StaticAnalyzer
{
    class QSO
    {
        //Frequency,Contest,CallTime              ,SentCallsign,SentStrength,SentZone,RecdCallsign,RecdStrength,RecdZone
        //21034    ,CW     ,11/25/2017 12:23:00 PM,2E0XAR      ,599         ,14      ,OE8Q        ,599         ,15

        public double Frequency { get; set; }
        public DateTime CallTime { get; set; }
        public string SentCall { get; set; }

        public QSO(string QSO)
        {
            string[] data = QSO.Split(',');

            Frequency = double.Parse(data[0]);
            CallTime = DateTime.Parse(data[2]);
            SentCall = data[3];
        }

        public string DateHour { get { return $"{CallTime.Date.ToString()} {CallTime.Hour.ToString()}"; } }
        public RadioInfo.BandName Band { get { return RadioInfo.DetermineBand(Frequency); } }

    }
}
