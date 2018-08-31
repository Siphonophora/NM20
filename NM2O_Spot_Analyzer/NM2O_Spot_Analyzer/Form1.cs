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
        
        public SpotAnalyzer Analyzer { get; set; } = new SpotAnalyzer();
        public BindingSource Source { get; set; } = new BindingSource();
        public UDPServerThread ServerThread { get; set; } = new UDPServerThread();

        public Form1()
        {
            InitializeComponent();

            InitalizeUDP();

            WireUpForm();
        }

        private void RefreshData()
        {
            Source.ResetBindings(false);
        }

        private void WireUpForm()
        {
            ServerThread.Server.UDPMessageEvent += Server_UDPMessageEvent;
            Analyzer.BufferUpdate += Buffer_BufferUpdate;


            Source.DataSource = Analyzer.Spots;
            SpotAnalysisGrid.DataSource = Source;
            
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerThread.Server.UDPMessageEvent -= Server_UDPMessageEvent;
            Analyzer.BufferUpdate -= Buffer_BufferUpdate;
            ServerThread.Thread.Abort();

        }

        private void Buffer_BufferUpdate(object sender, SpotAnalysisUpdatedEventArgs e)
        {
            textUDPScroll.Text = Analyzer.Buffer;
            RefreshData();
        }

        private void Server_UDPMessageEvent(object sender, UDPMessageRecievedEventArgs e)
        {
            Invoke((MethodInvoker)delegate { Analyzer.ParseMessage(e.Message); });
        }

        private void InitalizeUDP()
        {

        }




        private void button_Click(object sender, EventArgs e)
        {
            SpotAnalysisGrid.Sort(SpotAnalysisGrid.Columns[0], ListSortDirection.Ascending);
            RefreshData();

            ClickCount++;
            output.Text = ClickCount.ToString();
        }

    }
}
