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
            var outtext = new List<string>();

            string[] templatehead = File.ReadAllLines("voacapx.dat.templatehead");
            outtext.AddRange(templatehead);

            string[] templatebody = File.ReadAllLines("voacapx.dat.templatebody");
            
            parser.Countries
                .OrderBy(x => x.FixedName)
                .ToList()                
                .ForEach(x => outtext.AddRange(CreateCountryFiles(x, templatebody)));


            string[] templatefoot = File.ReadAllLines("voacapx.dat.templatefoot");
            outtext.AddRange(templatefoot);


            File.WriteAllLines($"C:\\itshfbc\\run\\NM2O_SpotAnalyzer.dat", outtext);
        }

        public List<string> CreateCountryFiles(Country country, string[] template)
        {
            var outtext = CreatePathFile(country, template, "S");
            outtext.AddRange(CreatePathFile(country, template, "L"));
            return outtext;
        }

        public List<string> CreatePathFile(Country country, string[] template, string path)
        {
            var outtext = new List<string>();

            for (int i = 0; i < template.Length; i++)
            {
                string templatestring = template[i];
                outtext.Add(templatestring
                    .Replace("$CountryName$", country.FixedName)
                    .Replace("$LatTo$", country.VoacapLat)
                    .Replace("$LongTo$", country.VoacapLong)
                    .Replace("$Path$", path));
            }
            return outtext;
        }
    }
}
