using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallParser
{
    public class CallPrefix : ICountryZone
    {
        public string Data { get; set; }
        public string Prefix
        {
            get
            {
                if (Data.Contains('('))
                {
                    return Data.Substring(0, Data.IndexOf('('));
                }
                if (Data.Contains('['))
                {
                    return Data.Substring(0, Data.IndexOf('['));
                }
                return Data;
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

        public CallPrefix(string data, Country country)
        {
            Data = data;
            FullCountry = country;
        }
    }
}
