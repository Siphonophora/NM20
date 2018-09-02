using System;

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NM2O_Spot_Analyzer
{
    public class SpotAnalyzer
    {
        public event EventHandler<SpotAnalysisUpdatedEventArgs> BufferUpdate;
        public List<Spot> Spots { get; set; } = new List<Spot>();
        public List<string> MessageBuffer { get; private set; } = new List<string>();
        public List<string> ActionLog { get; private set; } = new List<string>();

        public void ParseMessage(string message)
        {
            MessageType messageType = ClassifyMessage(message);

            if (messageType == MessageType.Spot)
            {
                //If add spot
                //1. Process it. 
                //2. Delete any Matching Call and Band
                //3. Add it. 
                //Notes: In the case that another contact that shares multipliers is made, you get an Add which is really an update, with the reduced mult status
                //Notes: When you 

                Spot s = new Spot(message);

                LogAction("Del/Add", s);
                DeleteSpot(s);
                AddSpot(s);
            }
            else if (messageType == MessageType.SpotDelete || messageType == MessageType.SpotDupe)
            {
                //If delete, or dupe, then parse the Spot delete it. 
                Spot s = new Spot(message, true);

                LogAction("Del", s);

                DeleteSpot(s);
            }
            else if (messageType == MessageType.Contact)
            {
                //If Contact, then parse the Contact and delete it. 
                Contact c = new Contact(message);

                LogAction("Contact", c);

                DeleteSpot(c);
            }

            MessageBuffer.Add($"{DateTime.Now.ToString("yyyy-dd-mm HH:mm:ss.ffffff")} | {Regex.Replace(message, @"\t|\n|\r", "")}");
            BufferUpdate?.Invoke(this, new SpotAnalysisUpdatedEventArgs());
        }

        public void LogAction(string action, ISpot s)
        {
            string log = $"{DateTime.Now.ToString("yyyy-dd-mm HH:mm:ss.ffffff")} |";
            log += $" { action.PadRight(10)}";
            log += $" { s.Call.PadRight(10)}";
            log += $" on { s.Band.ToString().PadRight(17)}";
            log += $" (Freq { s.Frequency.ToString("0.00").PadLeft(8)})";

            ActionLog.Add(log);
        }

        public void DeleteSpot(ISpot spot)
        {
            Spots.RemoveAll(x => x.Call == spot.Call && x.Band == spot.Band);
        }

        public void AddSpot(Spot spot)
        {
            Spots.Add(spot);
        }

        public enum MessageType { Spot, SpotDelete, SpotDupe, Contact, Unknown }

        public MessageType ClassifyMessage(string message)
        {
            XElement element = XElement.Parse(message);

            if (element.Name == "spot")
            {
                if (element.Element("action").Value == "delete")
                {
                    return MessageType.SpotDelete;
                }

                if (element.Element("status").Value == "dupe")
                {
                    return MessageType.SpotDupe;
                }

                return MessageType.Spot;
            }
            else if (element.Name == "contactinfo")
            {
                return MessageType.Contact;
            }

            return MessageType.Unknown;
        }


    }
}
