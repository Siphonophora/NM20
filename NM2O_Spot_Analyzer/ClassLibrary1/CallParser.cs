using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CallParser
{
    public class CountryParser
    {
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<CallPrefix> CallPrefixes { get; set; } = new List<CallPrefix>();
        public List<CallOverride> CallOverrides { get; set; } = new List<CallOverride>();

        public CountryParser(string file)
        {
            Parse(file);
        }

        public void Parse(string file)
        {
            string[] lines = File.ReadAllLines(file);
            List<List<string>> CountryRaw = new List<List<string>>();
            List<string> s = new List<string>();

            foreach (string line in lines)
            {
                if (line[0] != ' ' && line[0] != '#') //Current country
                {
                    if (s.Count > 0)
                    {
                        CountryRaw.Add(s);
                        s = new List<string>();
                    }
                }
                s.Add(line);
            }

            foreach (var raw in CountryRaw)
            {
                Country country = new Country(raw[0]);
                Countries.Add(country);
                for (int i = 1; i < raw.Count; i++)
                {
                    ParseCallRows(raw[i], country);
                }
            }
        }

        public void ParseCallRows(string dat, Country country)
        {
            if (dat.Contains(':'))
            {
                dat = dat.Substring(dat.IndexOf(':') + 1);
            }
            if (dat.Contains(';'))
            {
                dat = dat.Substring(0, dat.IndexOf(';'));
            }
            string[] d = dat.Split(',');
            foreach (var item in d)
            {
                string i = item.Trim();
                if (i.Length > 0)
                {
                    ParseSingle(i, country);
                }
            }
        }

        public void ParseSingle(string data, Country country)
        {
            if (data.Contains('='))
            {
                CallOverrides.Add(new CallOverride(data, country));
            }
            else
            {
                CallPrefixes.Add(new CallPrefix(data, country));
            }
        }

        public ICountryZone CheckCall(string call)
        {
            ICountryZone co = CallOverrides.Where(x => x.Call == call).FirstOrDefault();
            if (co != null)
            {
                return co;
            }
            //TODO pick apart spots with slashes. 
            for (int i = call.Length; i > 0; i--)
            {
                ICountryZone cp = CallPrefixes.Where(x => string.Equals(x.Prefix, call.Substring(0, i), StringComparison.CurrentCultureIgnoreCase) == true).FirstOrDefault();
                if (cp != null)
                {
                    return cp;
                }
            }

            throw new Exception();
        }
    }
}
