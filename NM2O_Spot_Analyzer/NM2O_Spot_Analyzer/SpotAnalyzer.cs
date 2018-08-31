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
        public string Buffer { get; private set; }

        public void ParseMessage(string message)
        {
            MessageType messageType = ClassifyMessage(message);

            if(messageType == MessageType.Spot)
            {
                //If add spot then process and add it
                Spots.Add(new Spot(message));
            } else if(messageType == MessageType.SpotDelete || messageType == MessageType.Contact)
            {
            //If delete or contact, then delete it. 

            }
            

            Buffer += $"{Regex.Replace(message, @"\t|\n|\r", "")}\r\n";
            BufferUpdate?.Invoke(this, new SpotAnalysisUpdatedEventArgs(Buffer));
        }


        public enum MessageType { Spot, SpotDelete, Contact, Unknown }

        public MessageType ClassifyMessage(string message)
        {
            XElement element = XElement.Parse(message);

            if (element.Name == "spot")
            {
                if (element.Element("action").Value == "delete")
                {
                    return MessageType.SpotDelete;
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
