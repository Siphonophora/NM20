using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLogCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int minQSOs = 5;

            string[] dirs = new string[]{ //@"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2015cw\",
                //@"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2016cw\",
                @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2017cw\" };
            //string dir = @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\MediumLogs\";

            foreach (var dir in dirs)
            {

                string dirin = $"{dir}CSV\\Submitted";
                string dirout = $"{dir}CSV\\Virtual";
                Directory.CreateDirectory(dirout);

                List<string> files = Directory.GetFiles(dirin).ToList();

                List<string[]> qsos = new List<string[]>();

                foreach (var file in files)
                {
                    Console.WriteLine($"Reading {file}");
                    var rows = File.ReadAllLines(file);

                    for (int i = 1; i < rows.Count(); i++)
                    {
                        qsos.Add(rows[i].Split(','));
                    }
                }

                List<string> submitters = new List<string>();
                List<string> callees = new List<string>();

                int n = 0;
                foreach (var qso in qsos)
                {
                    if (!submitters.Contains(qso[3]))
                    {
                        submitters.Add(qso[3]);
                    }

                    if (!callees.Contains(qso[6]))
                    {
                        callees.Add(qso[6]);
                    }
                    n++;
                    Console.WriteLine(n);
                }

                var missinglogs = callees.Where(x => !submitters.Any(y => y == x)).ToList();
                string header = "Frequency,Contest,CallTime,SentCallsign,SentStrength,SentZone,RecdCallsign,RecdStrength,RecdZone";

                foreach (var log in missinglogs)
                {
                    Console.WriteLine($"Writing {log}");
                    var logitems = qsos.Where(x => x[6] == log).ToList();

                    if (logitems.Count > minQSOs)
                    {
                        List<string> formattedItems = new List<string>();
                        formattedItems.Add(header);

                        foreach (var q in logitems)
                        {
                            formattedItems.Add($"{q[0]},{q[1]},{q[2]},{q[6]},{q[7]},{q[8]},{q[3]},{q[4]},{q[5]}");
                        }

                        string outfile = $"{dirout}\\{log.Replace('/', '_')}_virtual.csv";

                        File.WriteAllLines(outfile, formattedItems);
                    }
                }
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
