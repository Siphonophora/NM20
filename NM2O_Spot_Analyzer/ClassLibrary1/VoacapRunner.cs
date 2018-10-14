using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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


            File.WriteAllLines($"C:\\itshfbc\\run\\NM2O_Voacap.dat", outtext);
            RunVoacap(@"C:\itshfbc\bin_win\", @"c:\itshfbc NM2O_Voacap.dat NM2O_Voacap.out");


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

        /// <summary>
        /// Runs an R script from a file using Rscript.exe.
        /// Example:  
        ///   RScriptRunner.RunFromCmd(curDirectory + @"\ImageClustering.r", "rscript.exe", curDirectory.Replace('\\','/'));
        /// Getting args passed from C# using R:
        ///   args = commandArgs(trailingOnly = TRUE)
        ///   print(args[1]);
        /// Source: https://stackoverflow.com/questions/4485943/executing-r-script-programmatically
        /// </summary>
        /// <param name="rCodeFilePath">File where your R code is located.</param>
        /// <param name="rScriptExecutablePath">Usually only requires "rscript.exe"</param>
        /// <param name="args">Multiple R args can be seperated by spaces.</param>
        /// <returns>Returns a string with the R responses.</returns>
        public static void RunVoacap(string rScriptExecutablePath, string args)
        {
            try
            {
                var info = new ProcessStartInfo(@"C:\itshfbc\bin_win\voacapw.exe")
                {
                    Arguments = args               
                };


                using (var proc = new Process())
                {
                    proc.StartInfo = info;
                    proc.Start();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Voacap failed: ", ex);
            }
        }
    }
}
