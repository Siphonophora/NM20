using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;


namespace CallParser
{
    public class VoacapRunner
    {
        //Voacap can be run using this command.
        //C:\itshfbc\bin_win>voacapw.exe c:\itshfbc voacapx.dat voacapx.out
        //Files must exist in the RUN directory. 


        public void Run(string LatFrom, string LongFrom)
        {
            CountryParser parser = new CountryParser(@"N1MM_CountryList.dat");
            var outtext = new List<string>();

            string[] templatehead = File.ReadAllLines("voacapx.dat.templatehead");

            foreach (string str in templatehead)
            {
                outtext.Add(str.Replace("$Year$", DateTime.UtcNow.Year.ToString())
                    .Replace("$Month$", DateTime.UtcNow.Month.ToString("00"))
                    .Replace("$Day$", DateTime.UtcNow.Day.ToString("00")));
            }

            

            string[] templatebody = File.ReadAllLines("voacapx.dat.templatebody");

            parser.Countries
                .OrderBy(x => x.FixedName)
                .ToList()
                .ForEach(x => outtext.AddRange(CreateCountryFiles(LatFrom, LongFrom, x, templatebody)));


            string[] templatefoot = File.ReadAllLines("voacapx.dat.templatefoot");
            outtext.AddRange(templatefoot);


            File.WriteAllLines($"C:\\itshfbc\\run\\NM2O_Voacap.dat", outtext);
            RunVoacap(@"C:\itshfbc\bin_win\", @"c:\itshfbc NM2O_Voacap.dat NM2O_Voacap.out");


        }

        public List<string> CreateCountryFiles(string LatFrom, string LongFrom, Country country, string[] template)
        {
            var outtext = CreatePathFile(LatFrom, LongFrom, country, template, "S");
            outtext.AddRange(CreatePathFile(LatFrom, LongFrom, country, template, "L"));
            return outtext;
        }

        public List<string> CreatePathFile(string LatFrom, string LongFrom, Country country, string[] template, string path)
        {
            var outtext = new List<string>();

            for (int i = 0; i < template.Length; i++)
            {
                string templatestring = template[i];
                outtext.Add(templatestring
                    .Replace("$CountryName$", country.FixedName)
                    .Replace("$LatTo$", country.VoacapLat)
                    .Replace("$LongTo$", country.VoacapLong)
                    .Replace("$LatFrom$", LatFrom)
                    .Replace("$LongFrom$", LongFrom)
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
