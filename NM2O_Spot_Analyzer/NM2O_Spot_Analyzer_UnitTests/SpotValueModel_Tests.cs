using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NM2O_Spot_Analyzer;
using NUnit.Framework;
using CallParser;
using Utility;

namespace NM2O_Spot_Analyzer_UnitTests
{
    class CountryZoneStub : ICountryZone
    {
        public CountryZoneStub(string country, int cQZone, int iTUZone)
        {
            Country = country;
            ITUZone = iTUZone;
            CQZone = cQZone;
        }

        public string Country { get; set; }
        public int ITUZone { get; set; }
        public int CQZone { get; set; }
    }


    [TestFixture]
    class SpotValueModel_Tests
    {
        [TestCase(35, "<?xml version=\"1.0\" encoding=\"utf-8\"?><spot><StationName>DESKTOP-6C0F16O</StationName><dxcall>3Z0X</dxcall><frequency>21150.06</frequency><spottercall>KO7SS-#</spottercall><comment>CW 11 DB 22 WPM NCDXF BCN </comment><action>add</action><status>double mult</status><timestamp>2018-08-29 01:21:51</timestamp></spot>")]
        public void asdfClassifyMessage_VariousNormalMessages_Succeed(double hours, string message)
        {
            var d = TestContext.CurrentContext.TestDirectory;
            PrecalculatedAnalysis.LoadAnalysis($"{d}\\Call_Analysis.csv", $"{d}\\CountryZone_Analysis.csv");

            var vm1 = new SpotValueModel("NM2O", new CountryZoneStub("United States", 5, 0), RadioInfo.BandName.EightyMeters, 2);
            var vm2 = new SpotValueModel("NM2O", new CountryZoneStub("Sri Lanka", 36, 0), RadioInfo.BandName.EightyMeters, 2);
            var vm3 = new SpotValueModel("NM2Ofooo", new CountryZoneStub("Sri Lanka", 36, 0), RadioInfo.BandName.EightyMeters, 2);
            var vm4 = new SpotValueModel("NM2O", new CountryZoneStub("Sri Lanka FOOOO", 36, 0), RadioInfo.BandName.EightyMeters, 2);

            Assert.AreEqual(true, false);
        }
    }
}
