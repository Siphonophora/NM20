using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace NM2O_Spot_Analyzer
{
    public class Contact : ISpot
    {
        public string Call { get; set; }
        public double Frequency { get; set; }
        public RadioInfo.BandName Band { get; set; }
        public DateTimeOffset OffsetTimestamp { get; set; }
        public DateTime LocalTimestamp { get { return OffsetTimestamp.LocalDateTime; } }

        public Contact() { }
        public Contact(string spotMessage)
        {
            XElement element = XElement.Parse(spotMessage);

            Call = element.Element("call").Value;
            Frequency = double.Parse(element.Element("rxfreq").Value) / 100d;
            OffsetTimestamp = DateTimeOffset.Parse($"{element.Element("timestamp").Value} -00:00");

            Band = RadioInfo.DetermineBand(Frequency);
        }
    }
}
