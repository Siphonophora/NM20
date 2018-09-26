using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallParser
{
    public class CallOverride : ICountryZone
    {
        public string Data { get; set; }
        public string Call
        {
            get
            {
                if (Data.Contains('('))
                {
                    return Data.Substring(1, Data.IndexOf('(') - 1);
                }
                if (Data.Contains('['))
                {
                    return Data.Substring(1, Data.IndexOf('[') - 1);
                }
                return Data.Substring(1);
            }
        }
        public int ZoneOverride
        {
            get
            {
                if (Data.Contains('('))
                {
                    return int.Parse(Data.Substring(Data.IndexOf('(') + 1, Data.IndexOf(')') - Data.IndexOf('(') - 1));
                }
                return -1;
            }
        }
        public int CountryOverride
        {
            get
            {
                if (Data.Contains('['))
                {
                    return int.Parse(Data.Substring(Data.IndexOf('[') + 1, Data.IndexOf(']') - Data.IndexOf('[') - 1));
                }
                return -1;
            }
        }
        public Country FullCountry { get; set; }
        public string Country { get { return FullCountry.Name; } }
        public int ITUZone => CountryOverride != -1 ? CountryOverride : FullCountry.CountryNum;
        public int CQZone => ZoneOverride != -1 ? ZoneOverride : FullCountry.Zone;

        public CallOverride(string data, Country country)
        {
            Data = data;
            FullCountry = country;
        }
    }
}
