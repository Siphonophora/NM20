using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallParser;

namespace NM2O_Spot_Analyzer
{
    public class Spot : ISpot
    {
        public string Call { get; set; }
        public double Frequency { get; set; }
        public string Action { get; set; }
        public string SpotterCall { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public DateTimeOffset OffsetTimestamp { get; set; }
        public DateTime LocalTimestamp { get { return OffsetTimestamp.LocalDateTime; } }
        public RadioInfo.BandName Band { get; set; }
        public RadioInfo.Mode Mode { get; set; }
        public double Value { get; set; }
        public ICountryZone CountryZone { get; set; }
        public string Country { get { return CountryZone.Country; } }         //TODO handle nulls. 
        public int Zone { get { return CountryZone.CQZone; } }         //TODO handle nulls. 

        public Spot() { }

        public Spot(string contactMessage, bool minInfo = false)
        {
            XElement element = XElement.Parse(contactMessage);

            Call = element.Element("dxcall").Value;
            Frequency = double.Parse(element.Element("frequency").Value);
            Band = RadioInfo.DetermineBand(Frequency);
            OffsetTimestamp = DateTimeOffset.Parse($"{element.Element("timestamp").Value} -00:00");

            if (!minInfo)
            {
                Action = element.Element("action").Value;
                SpotterCall = element.Element("spottercall").Value;
                Comment = element.Element("comment").Value;
                Status = element.Element("status").Value;
                Mode = RadioInfo.DetermineMode(Comment);

                Value = PrecalculatedAnalysis.GetValue(Call);
            }

            try
            {
                CountryZone = MainForm.CallParser.CheckCall(Call);
            }
            catch (Exception)
            {

                //just catch this
            }
        }
    }
}
