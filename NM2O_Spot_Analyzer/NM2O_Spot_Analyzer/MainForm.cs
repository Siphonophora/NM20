using CallParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace NM2O_Spot_Analyzer
{
    public partial class MainForm : Form
    {
        public int ClickCount { get; set; } = 0;

        public SpotAnalyzer Analyzer { get; set; } = new SpotAnalyzer();
        public BindingSource Source { get; set; } = new BindingSource();
        public UDPServerThread ServerThread { get; set; } = new UDPServerThread();
        public List<Spot> Spots = new List<Spot>();
        public static CountryParser CallParser = new CountryParser(@"N1MM_CountryList.dat");
        public static VoacapPropogation VoacapPropogation { get; set; } = new VoacapPropogation();

        public MainForm()
        {
            try
            {
                InitializeComponent();
                InitalizeMainForm();
                WireUpForm();
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}\r\n\r\n{e.Message}\r\n\r\n{e.HelpLink}\r\n\r\n{e.StackTrace}", "Error in Main form Initalization");
            }
        }

        private void InitalizeMainForm()
        {
            this.Height = Properties.Settings.Default.MainFormHeight;
            this.Width = Properties.Settings.Default.MainFormWidth;
            this.Location = Properties.Settings.Default.MainFormLocation;
            this.StartPosition = FormStartPosition.Manual;

            IPLabel.Text = $"Connect N1MM to {IPHelper.GetLocalIPAddress()} port 12060";
            PrecalculatedAnalysis.LoadAnalysis(@"Call_Analysis.csv", @"CountryZone_Analysis.csv");
            LoadPropButton_Click(this, null);
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ServerThread.Server.UDPMessageEvent -= Server_UDPMessageEvent;
            Analyzer.BufferUpdate -= Buffer_BufferUpdate;
            ServerThread.Thread.Abort();

            Directory.CreateDirectory($"C:\\temp\\");
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
            //Get propogations
            foreach (Spot spot in Analyzer.Spots)
            {
                spot.Propogation = VoacapPropogation.CurrentPropogation(spot.FixedCountryName, spot.Band);
            }


            Spots.RemoveAll(x => x.Frequency > 0);
            List<RadioInfo.BandName> selectedBands = new List<RadioInfo.BandName>();
            foreach (var o in RadioBandsListBox.SelectedItems)
            {
                selectedBands.Add((RadioInfo.BandName)o);
            }

            List<RadioInfo.Mode> selectedModes = new List<RadioInfo.Mode>();
            foreach (var o in SpottedModeListBox.SelectedItems)
            {
                selectedModes.Add((RadioInfo.Mode)o);
            }


            Spots.AddRange(Analyzer.Spots.Where(x => selectedModes.Contains(x.Mode)
                                                    && selectedBands.Contains(x.Band)
                                                    && (x.Country != "United States" || x.Multiplier > 0)
                                                    ).OrderByDescending(x => x.Value));
            Source.ResetBindings(false);

            DisplaySpots.Text = Spots.Count.ToString();
            AllSpots.Text = Analyzer.Spots.Count.ToString();
        }

        private void WireUpForm()
        {
            ServerThread.Server.UDPMessageEvent += Server_UDPMessageEvent;
            Analyzer.BufferUpdate += Buffer_BufferUpdate;

            SpottedModeListBox.DataSource = Enum.GetValues(typeof(RadioInfo.Mode));
            RadioBandsListBox.DataSource = Enum.GetValues(typeof(RadioInfo.BandName));

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
            try
            {
                Invoke((MethodInvoker)delegate { Analyzer.ParseMessage(e.Message); });
            }
            catch (Exception)
            {
                Analyzer.ActionLog.Add($"{DateTime.Now.ToString("yyyy-dd-mm HH:mm:ss.ffffff")} | Parsing Failed for {e.Message}");
            }
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

        private void LoadPropButton_Click(object sender, EventArgs e)
        {
            VoacapPropogation.Load();
            PropDateLabel.Text = "Run on : " + VoacapPropogation.PropDate.ToShortDateString();
        }

        private void RunPropButton_Click(object sender, EventArgs e)
        {
            VoacapPropogation.Run(LatFrom.Text, LongFrom.Text);
        }

        private void IncreaseFontSize_Click(object sender, EventArgs e)
        {
            ChangeFontSize(1);
        }

        private void DecreaseFontSize_Click(object sender, EventArgs e)
        {
            ChangeFontSize(-1);
        }

        private void ChangeFontSize(float dif)
        {
            var font = this.Font;
            if((font.Size + dif ) < 4)
            {
                MessageBox.Show("Font Cannot be Smaller", "Sorry!");
                return;
            }

            this.Font = new System.Drawing.Font(font.FontFamily, font.Size + dif);
        }
    }
}
