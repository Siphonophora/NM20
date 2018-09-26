using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NM2O_Spot_Analyzer;

namespace NM2O_Spot_Analyzer_UnitTests
{
    [TestFixture]
    class Spot_Tests
    {
        [TestCase(35, "<?xml version=\"1.0\" encoding=\"utf-8\"?><spot><StationName>DESKTOP-6C0F16O</StationName><dxcall>3Z0X</dxcall><frequency>21150.06</frequency><spottercall>KO7SS-#</spottercall><comment>CW 11 DB 22 WPM NCDXF BCN </comment><action>add</action><status>double mult</status><timestamp>2018-08-29 01:21:51</timestamp></spot>")]
        public void asdfClassifyMessage_VariousNormalMessages_Succeed(double hours, string message)
        {
            PrecalculatedAnalysis.LoadAnalysis(@"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2017cw\analysis.csv");

            Spot spot = new Spot(message);;

            Assert.AreEqual(hours, spot.Value);
        }

        [TestCase("W6WX", "<?xml version=\"1.0\" encoding=\"utf-8\"?><spot><StationName>DESKTOP-6C0F16O</StationName><dxcall>W6WX</dxcall><frequency>21150.06</frequency><spottercall>KO7SS-#</spottercall><comment>CW 11 DB 22 WPM NCDXF BCN </comment><action>add</action><status>double mult</status><timestamp>2018-08-29 01:21:51</timestamp></spot>")]
        public void SpotConstructor_VariousNormalMessages_Succeed(string call, string message)
        {
            Spot spot = new Spot(message);

            Assert.AreEqual(call, spot.Call);
        }
    }
}




