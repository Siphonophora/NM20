using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace CallParser
{
    public class Propogation
    {
        public Propogation(string country, float hour, string path, float rel, RadioInfo.BandName band)
        {
            Country = country;
            Hour = hour;
            Band = band;
            Path = path;
            Rel = rel;
        }

        public string Country { get; set; }
        public float Hour { get; set; }
        public RadioInfo.BandName Band { get; set; }
        public string Path { get; set; }
        public float Rel { get; set; }
    }
}
