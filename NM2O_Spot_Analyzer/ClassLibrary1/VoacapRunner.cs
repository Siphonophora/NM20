using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallParser
{
    public class VoacapRunner
    {
        //Voacap can be run using this command.
        //C:\itshfbc\bin_win>voacapw.exe c:\itshfbc voacapx.dat voacapx.out
        //Files must exist in the RUN directory. 


        public void Run()
        {
            CountryParser parser = new CountryParser(@"N1MM_CountryList.dat");
            string[] template = File.ReadAllLines("voacapx.dat.template");
            parser.Countries.ForEach(x => CreateCountryFiles(x, template));

        }

        public void CreateCountryFiles(Country country, string[] template)
        {
            CreatePathFile(country, template, "S");
            CreatePathFile(country, template, "L");
        }

        public void CreatePathFile(Country country, string[] template, string path)
        {
            List<string> outtext = new List<string>();

            for (int i = 0; i < template.Length; i++)
            {
                string templatestring = template[i];
                outtext.Add(templatestring
                    .Replace("$CountryName$", country.FixedName)
                    .Replace("$LatTo$", country.VoacapLat)
                    .Replace("$LongTo$", country.VoacapLong)
                    .Replace("$Path$", path));
            }
            File.WriteAllLines($"C:\\itshfbc\\run\\{country.FixedName}_{path}.dat", outtext);
        }
    }
}
