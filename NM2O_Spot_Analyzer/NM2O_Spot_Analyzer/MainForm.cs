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
using System.IO;


namespace NM2O_Spot_Analyzer
{
    public partial class MainForm : Form
    {
        public int ClickCount { get; set; } = 0;

        public SpotAnalyzer Analyzer { get; set; } = new SpotAnalyzer();
        public BindingSource Source { get; set; } = new BindingSource();
        public UDPServerThread ServerThread { get; set; } = new UDPServerThread();
        public List<Spot> Spots { get; set; } = new List<Spot>();

        public MainForm()
        {
            InitializeComponent();
            InitalizeMainForm();
            WireUpForm();
        }

        private void InitalizeMainForm()
        {
            this.Height = Properties.Settings.Default.MainFormHeight;
            this.Width = Properties.Settings.Default.MainFormWidth;
            this.Location = Properties.Settings.Default.MainFormLocation;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ServerThread.Server.UDPMessageEvent -= Server_UDPMessageEvent;
            Analyzer.BufferUpdate -= Buffer_BufferUpdate;
            ServerThread.Thread.Abort();

            File.WriteAllLines($"C:\\temp\\NM2O Analysis Log - {DateTime.Now.ToString("yyyy-MM-dd HH-mm")} Messages.txt", Analyzer.MessageBuffer);
            File.WriteAllLines($"C:\\temp\\NM2O Analysis Log - {DateTime.Now.ToString("yyyy-MM-dd HH-mm")} Actions.txt", Analyzer.ActionLog);

            Properties.Settings.Default.MainFormHeight = this.Height;
            Properties.Settings.Default.MainFormWidth = this.Width;
            Properties.Settings.Default.MainFormLocation = this.Location;
            Properties.Settings.Default.Save();
        }

        private void RefreshData(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            Spots.RemoveAll(x => x.Frequency > 0);
            List<RadioInfo.BandName> selectedBands = new List<RadioInfo.BandName>();
            foreach (var o in listBox1.SelectedItems)
            {
                selectedBands.Add((RadioInfo.BandName)o);
            }
            Spots.AddRange(Analyzer.Spots.Where(x =>   x.Mode == (RadioInfo.Mode)comboBox1.SelectedValue
                                                    && selectedBands.Contains(x.Band)
                                                    ).OrderByDescending(x => x.Value));
            Source.ResetBindings(false);

            DisplaySpots.Text = Spots.Count.ToString();
            AllSpots.Text = Analyzer.Spots.Count.ToString();
        }

        private void WireUpForm()
        {
            ServerThread.Server.UDPMessageEvent += Server_UDPMessageEvent;
            Analyzer.BufferUpdate += Buffer_BufferUpdate;

            SevenMHz.DataSource = Enum.GetValues(typeof(RadioInfo.BandName));

            comboBox1.DataSource = Enum.GetValues(typeof(RadioInfo.Mode));
            listBox1.DataSource = Enum.GetValues(typeof(RadioInfo.BandName));

            Source.DataSource = Spots;
            SpotAnalysisGrid.DataSource = Source;

        }

        private void Buffer_BufferUpdate(object sender, SpotAnalysisUpdatedEventArgs e)
        {
            RawXMLMessageLog.Text = Analyzer.MessageBuffer.Aggregate((i, j) => i + "\r\n" + j);
            ActionLog.Text = Analyzer.ActionLog.Aggregate((i, j) => i + "\r\n" + j);
            RefreshData();
        }

        private void Server_UDPMessageEvent(object sender, UDPMessageRecievedEventArgs e)
        {
            Invoke((MethodInvoker)delegate { Analyzer.ParseMessage(e.Message); });
        }

        private void TimezoneOffset_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                var v = int.Parse(tb.Text);
                if (v > 14 || v < -12)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                e.Cancel = true;
                Properties.Settings.Default.Reload();
                tb.Text = Properties.Settings.Default.TimeZoneOffset;
                MessageBox.Show("Timezone must be an integer from -12 to 14");
            }

            e.Cancel = false;
            Properties.Settings.Default.Save();
        }

        private void KeyPressEnter_NoDing(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

    }
}
