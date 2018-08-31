using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2O_Spot_Analyzer
{
    public class Spot
    {
        public Spot() { }
        public Spot(string spotMessage)
        {
            XElement element = XElement.Parse(spotMessage);

            Call = element.Element("dxcall").Value;
            Val = -1;

        }


        public string Call { get; set; }
        public int Val { get; set; }
    }
}
