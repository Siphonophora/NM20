using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallParser;
using Utility;

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
        public int Multiplier
        {
            get
            {
                if (Status.Contains("doub"))
                {
                    return 2;
                }
                else if (Status.Contains("sing"))
                {
                    return 1;
                }
                return 0;
            }
        }
        public DateTimeOffset OffsetTimestamp { get; set; }
        public DateTime LocalTimestamp { get { return OffsetTimestamp.LocalDateTime; } }
        public RadioInfo.BandName Band { get; set; }
        public RadioInfo.Mode Mode { get; set; }
        public SpotValueModel ValueModel { get; set; }
        public double Value
        {
            get
            {
                try
                {
                    if (Propogation.Rel > -1)
                    {
                        return ValueModel.Value * Propogation.RelValueMult;
                    }
                }
                catch (Exception)
                {
                    //Nothing just catching missing REL
                }
                return ValueModel.Value;
            }
        }
        public string ValueString { get { return Value.ToString("0.0"); } }
        public string ValueModelString { get { return ValueModel.ToString(); } }
        public ICountryZone CountryZone { get; set; }
        public string Country { get { return CountryZone.Country; } }         //TODO handle nulls. 
        public string FixedCountryName { get { return Country.Replace('.', '_').Replace(' ', '_').Substring(0, Country.Length > 20 ? 20 : Country.Length); } }
        public int Zone { get { return CountryZone.CQZone; } }         //TODO handle nulls. 
        public Propogation Propogation { get; set; }

        public Spot() { }

        public Spot(string contactMessage, bool minInfo = false)
        {
            XElement element = XElement.Parse(contactMessage);

            Call = element.Element("dxcall").Value;
            Frequency = double.Parse(element.Element("frequency").Value);
            Band = RadioInfo.DetermineBand(Frequency);
            OffsetTimestamp = DateTimeOffset.Parse($"{element.Element("timestamp").Value} -00:00");
            CountryZone = MainForm.CallParser.CheckCall(Call);

            if (!minInfo)
            {
                Action = element.Element("action").Value;
                SpotterCall = element.Element("spottercall").Value;
                Comment = element.Element("comment").Value;
                Status = element.Element("status").Value;
                Mode = RadioInfo.DetermineMode(Comment);

                ValueModel = new SpotValueModel(Call, CountryZone, Band, Multiplier);
            }
        }

        public string PropogationRel
        {
            get
            {
                try
                {
                    if(Propogation.Rel == -1)
                    {
                        return "Unavailable";
                    }

                    return $"x{Propogation.RelValueMult.ToString("0.0")} <= {(Propogation.Path == "S" ? "Short: " : "Long: ")}{Propogation.Rel.ToString("0.00")}";
                }
                catch (Exception)
                {
                    return "Unavailable";
                }
            }
        }
    }
}
