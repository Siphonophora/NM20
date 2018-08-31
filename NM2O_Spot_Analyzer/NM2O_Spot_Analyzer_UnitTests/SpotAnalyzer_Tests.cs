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
    class SpotAnalyzer_Tests
    {
        [TestCase(SpotAnalyzer.MessageType.Spot, "<?xml version=\"1.0\" encoding=\"utf-8\"?><spot><StationName>DESKTOP-6C0F16O</StationName><dxcall>W6WX</dxcall><frequency>21150.06</frequency><spottercall>KO7SS-#</spottercall><comment>CW 11 DB 22 WPM NCDXF BCN </comment><action>add</action><status>double mult</status><timestamp>2018-08-29 01:21:51</timestamp></spot>")]
        [TestCase(SpotAnalyzer.MessageType.SpotDelete, "<?xml version=\"1.0\" encoding=\"utf-8\"?><spot><StationName>DESKTOP-6C0F16O</StationName><dxcall>YO5AJR</dxcall><frequency>7013.97</frequency><action>delete</action><timestamp>2018-08-29 01:22:10</timestamp></spot>")]
        [TestCase(SpotAnalyzer.MessageType.Contact, "<?xml version=\"1.0\" encoding=\"utf-8\"?><contactinfo><contestname>CQWWCW</contestname><contestnr>1</contestnr><timestamp>2018-08-29 01:22:05</timestamp><mycall>NM2O</mycall><band>21</band><rxfreq>2115006</rxfreq><txfreq>2115006</txfreq><operator>NM2O</operator><mode>CW</mode><call>W6WX</call><countryprefix>K</countryprefix><wpxprefix>W6</wpxprefix><stationprefix>NM2O</stationprefix><continent>NA</continent><snt>599</snt><sntnr>18</sntnr><rcv>599</rcv><rcvnr>0</rcvnr><gridsquare></gridsquare><exchange1></exchange1><section></section><comment></comment><qth></qth><name></name><power></power><misctext></misctext><zone>3</zone><prec></prec><ck>0</ck><ismultiplier1>1</ismultiplier1><ismultiplier2>1</ismultiplier2><ismultiplier3>0</ismultiplier3><points>0</points><radionr>1</radionr><RoverLocation></RoverLocation><RadioInterfaced>0</RadioInterfaced><NetworkedCompNr>0</NetworkedCompNr><IsOriginal>True</IsOriginal><NetBiosName>DESKTOP-6C0F16O</NetBiosName><IsRunQSO>0</IsRunQSO><StationName>DESKTOP-6C0F16O</StationName></contactinfo>")]
        public void ClassifyMessage_VariousNormalMessages_Succeed(SpotAnalyzer.MessageType expectedType, string message)
        {
            SpotAnalyzer analyzer = new SpotAnalyzer();

            var messageclass = analyzer.ClassifyMessage(message);

            Assert.AreEqual(expectedType, messageclass);
        }

        [TestCase("W6WX", "<?xml version=\"1.0\" encoding=\"utf-8\"?><spot><StationName>DESKTOP-6C0F16O</StationName><dxcall>W6WX</dxcall><frequency>21150.06</frequency><spottercall>KO7SS-#</spottercall><comment>CW 11 DB 22 WPM NCDXF BCN </comment><action>add</action><status>double mult</status><timestamp>2018-08-29 01:21:51</timestamp></spot>")]
        public void SpotConstructor_VariousNormalMessages_Succeed(string call, string message)
        {
            Spot spot = new Spot(message);

            Assert.AreEqual(call, spot.Call);
        }
    }
}




