using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace NM2O_Spot_Analyzer
{
    public partial class Form1 : Form
    {
        public int ClickCount { get; set; } = 0;
        public UDPServer Server { get; set; }
        public SpotAnalyzer Analyzer { get; set; } = new SpotAnalyzer();

        public Form1()
        {
            InitializeComponent();

            InitalizeUDP();

            WireUpForm();
        }

        private void WireUpForm()
        {
            Server.UDPMessageEvent += Server_UDPMessageEvent;
            Analyzer.BufferUpdate += Buffer_BufferUpdate;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Server.UDPMessageEvent -= Server_UDPMessageEvent;
            Analyzer.BufferUpdate -= Buffer_BufferUpdate;
            
        }

        private void Buffer_BufferUpdate(object sender, SpotAnalysisUpdatedEventArgs e)
        {
            textUDPScroll.Text = Analyzer.Buffer;
            
        }

        private void Server_UDPMessageEvent(object sender, UDPMessageRecievedEventArgs e)
        {
            Invoke((MethodInvoker)delegate { Analyzer.ParseMessage($"{e.Message}\r\n"); });
        }

        private void InitalizeUDP()
        {
            Server = new UDPServer();
            Thread thread = new Thread(new ThreadStart(Server.ServerThread));
            thread.Start();
        }




        private void button_Click(object sender, EventArgs e)
        {
            ClickCount++;
            output.Text = ClickCount.ToString();
        }

    }
}
