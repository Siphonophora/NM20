using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CallParser.UnitTests
{
    [TestFixture]
    class Countries_Tests
    {
        [Test]
        public void CountryParseSimple()
        {
            CountryParser countries = new CountryParser(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\NM2O_Spot_Analyzer\bin\Debug\N1MM_CountryList.dat");

            ICountryZone a = countries.CheckCall("BY8A1");
            Assert.AreEqual(false, true);
        }

        [TestCase("JJ1X2")]
        [TestCase("jj1y2")]
        public void CountryParse_CasesFromJapan_Pass(string call)
        {
            CountryParser countries = new CountryParser(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\NM2O_Spot_Analyzer\bin\Debug\N1MM_CountryList.dat");

            ICountryZone a = countries.CheckCall(call);
            Assert.AreEqual("Japan", a.Country);
        }
    }
}
