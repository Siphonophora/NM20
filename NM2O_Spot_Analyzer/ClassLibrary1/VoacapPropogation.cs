using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace CallParser
{
    public class VoacapPropogation
    {
        public VoacapRunner VoacapRunner { get; private set; }

        List<Propogation> Propogations { get; set; }
        public DateTime PropDate { get; private set; }


        public void Load()
        {
            Propogations = ParsePropogations();
        }

        public void Run(string LatFrom, string LongFrom)
        {
            VoacapRunner = new VoacapRunner();
            VoacapRunner.Run(LatFrom, LongFrom); //TODO enable this?
        }

        /// <summary>
        /// This is a fairly naieve parser. May not handle all situations correctly if voacap output varies. 
        /// </summary>
        /// <returns></returns>
        private List<Propogation> ParsePropogations()
        {
            List<Propogation> newProps = new List<Propogation>();

            //TODO the program will fail if the file doesn't exist
            string file = @"C:\itshfbc\run\nm2o_voacap.out";
            var fileInfo = new FileInfo(file);
            PropDate = fileInfo.LastWriteTime;
            string[] rows = File.ReadAllLines(file);

            string country = "";
            string path = "";
            int hour = 0;


            for (int i = 0; i < rows.LongLength; i++)
            {
                string row = rows[i].PadRight(80); //Pad this so we don't get errors on the substring being out of range. 
                if (row.Substring(62, 6).Equals("N. MI."))
                {
                    path = row.Substring(2, 1);
                    country = row.Substring(22, 20).TrimEnd();
                }
                else if (row.Substring(67, 4).Equals("FREQ"))
                {
                    hour = int.Parse(row.Substring(2, 2));
                }
                else if (row.Substring(67, 3).Equals("REL"))
                {
                    newProps.Add(new Propogation(country, hour, path, float.Parse(row.Substring(12, 4)), RadioInfo.BandName.OneSixtyMeters));
                    newProps.Add(new Propogation(country, hour, path, float.Parse(row.Substring(17, 4)), RadioInfo.BandName.EightyMeters));
                    newProps.Add(new Propogation(country, hour, path, float.Parse(row.Substring(22, 4)), RadioInfo.BandName.FourtyMeters));
                    newProps.Add(new Propogation(country, hour, path, float.Parse(row.Substring(27, 4)), RadioInfo.BandName.TwentyMeters));
                    newProps.Add(new Propogation(country, hour, path, float.Parse(row.Substring(32, 4)), RadioInfo.BandName.FifteenMeters));
                    newProps.Add(new Propogation(country, hour, path, float.Parse(row.Substring(37, 4)), RadioInfo.BandName.TenMeters));
                }
            }

            return newProps;
        }

        public Propogation CurrentPropogation(string countryFixedName, RadioInfo.BandName band)
        {
            int hn = DateTime.UtcNow.Hour;
            int hf = hn == 24 ? 0 : hn + 1;

            try
            {
                Propogation psn = GetPropogationRel(countryFixedName, band, "S", hn); //psn = Prop Short Now
                Propogation pln = GetPropogationRel(countryFixedName, band, "L", hn);
                Propogation psf = GetPropogationRel(countryFixedName, band, "S", hf);
                Propogation plf = GetPropogationRel(countryFixedName, band, "L", hf);

                if (psn.Rel >= pln.Rel)
                {
                    return InterpolatePropogation(psn, psf);
                }
                else
                {
                    return InterpolatePropogation(pln, plf);
                }

            }
            catch (Exception)
            {
                return new Propogation(countryFixedName, 0, "S", -1, band);
                //Dont rethrow, just return the negative REL. 
            }
        }

        private Propogation GetPropogationRel(string countryFixedName, RadioInfo.BandName band, string path, int hour)
        {
            try
            {
                return Propogations.Where(x => x.Country == countryFixedName
                                            && x.Band == band
                                            && x.Hour == hour
                                            && x.Path == path
                                            ).First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Linear interpolation between propogations. 
        /// </summary>
        /// <param name="pn"></param>
        /// <param name="pf"></param>
        /// <returns></returns>
        private Propogation InterpolatePropogation(Propogation pn, Propogation pf)
        {
            float hfract = (float)DateTime.UtcNow.Minute / 60;
            float newrel = pn.Rel + ((pf.Rel - pn.Rel) * hfract);

            return new Propogation(pn.Country, pn.Hour + hfract, pn.Path, newrel, pn.Band);
        }
    }
}
