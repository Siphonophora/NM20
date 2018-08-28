using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDPServer;

namespace NM2O_Spot_Analyzer
{
    public partial class Form1 : Form
    {
        public int ClickCount { get; set; } = 0;
        

        public Form1()
        {
            InitializeComponent();

            WireUpForm();
        }

        private void WireUpForm()
        {
            System.Threading.Thread.Sleep(10000);
            UDPServerProgram.Server.UDPMessageEvent += Server_UDPMessageEvent;
        }

        private void Server_UDPMessageEvent(object sender, UDPMessageRecievedEventArgs e)
        {
            ClickCount++;
            output.Text = ClickCount.ToString();
        }


        private void button_Click(object sender, EventArgs e)
        {
            ClickCount++;
            output.Text = ClickCount.ToString();
        }
    }
}
