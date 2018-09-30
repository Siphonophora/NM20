using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CountryZoneAnalysis
    {
        public enum Type { Country, Zone, Totals };


        public Type CZType { get; set; }
        public string Label { get; set; }
        public int TotalHours { get; set; }
        public int OnePointEightMHz { get; set; }
        public int ThreePointFiveMHz { get; set; }
        public int SevenMHz { get; set; }
        public int FourteenMHz { get; set; }
        public int TwentyOneMHz { get; set; }
        public int TwentyEightMHz { get; set; }
        public int None { get; set; }

        public CountryZoneAnalysis(string label, string info, Type type)
        {
            CZType = type;
            Label = label;
            Add(info);
        }

        public CountryZoneAnalysis(string fullinfo)
        {
            var splitinfo = fullinfo.Split(new char[] { ',' }, 3);
            CZType = (Type)Enum.Parse(typeof(Type), splitinfo[0]);
            Label = splitinfo[1];
            if(CZType == Type.Zone)
            {
                Label = int.Parse(Label).ToString(); //Strip any leading zeros
            }
            Add("foo," +splitinfo[2]); //Add function expects to have the label
        }

        public void Add(string info)
        {
            TotalHours += int.Parse(info.Split(',')[1]);
            OnePointEightMHz += int.Parse(info.Split(',')[2]);
            ThreePointFiveMHz += int.Parse(info.Split(',')[3]);
            SevenMHz += int.Parse(info.Split(',')[4]);
            FourteenMHz += int.Parse(info.Split(',')[5]);
            TwentyOneMHz += int.Parse(info.Split(',')[6]);
            TwentyEightMHz += int.Parse(info.Split(',')[7]);
            None += int.Parse(info.Split(',')[8]);
        }



        public override string ToString()
        {
            return $"{CZType},{(CZType == Type.Zone && Label.Length == 1 ? "0" : "")}{Label},{TotalHours},{OnePointEightMHz},{ThreePointFiveMHz},{SevenMHz},{FourteenMHz},{TwentyOneMHz},{TwentyEightMHz},{None}";
        }

    }
}
