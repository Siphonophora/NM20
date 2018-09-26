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
            CountryParser countries = new CountryParser(@"C:\Users\mike\Documents\GitHub\NM20\NM2O_Spot_Analyzer\StaticAnalyzer\N1MM_CountryList.dat");

            ICountryZone a = countries.CheckCall("BY8A1");
            Assert.AreEqual(false, true);
        }
    }
}
