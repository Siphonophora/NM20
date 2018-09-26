using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallParser
{
    public class Country
    {
        public string Name { get; set; }
        public int Zone { get; set; }
        public int CountryNum { get; set; }
        public string Continent { get; set; }
        public float Long { get; set; }
        public float Lat { get; set; }
        public float TimezoneOffset { get; set; }
        public string DefaultPrefix { get; set; }

        public Country(string data)
        {
            string[] dat = data.Split(':');

            Name = dat[0].Trim();
            Zone = int.Parse(dat[1].Trim());
            CountryNum = int.Parse(dat[2].Trim());
            Continent = dat[3].Trim();
            Long = float.Parse(dat[4].Trim());
            Lat = float.Parse(dat[5].Trim());
            TimezoneOffset = float.Parse(dat[6].Trim());
            DefaultPrefix = dat[7].Trim();

        }
    }
}
