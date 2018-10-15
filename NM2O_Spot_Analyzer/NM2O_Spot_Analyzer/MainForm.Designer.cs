namespace NM2O_Spot_Analyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AnalysisPage = new System.Windows.Forms.TabPage();
            this.SpotAnalysisGrid = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Band = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropogationRel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpotterCall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawLogPage = new System.Windows.Forms.TabPage();
            this.RawXMLMessageLog = new System.Windows.Forms.TextBox();
            this.ActionLogPage = new System.Windows.Forms.TabPage();
            this.ActionLog = new System.Windows.Forms.TextBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.LongFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LatFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimezoneOffset = new System.Windows.Forms.TextBox();
            this.AllSpotsLabel = new System.Windows.Forms.Label();
            this.AllSpots = new System.Windows.Forms.Label();
            this.DisplaySpots = new System.Windows.Forms.Label();
            this.DisplaySpotsLabel = new System.Windows.Forms.Label();
            this.RadioBandsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpottedModeListBox = new System.Windows.Forms.ListBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadPropButton = new System.Windows.Forms.Button();
            this.RunPropButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PropDateLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.callDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.AnalysisPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotAnalysisGrid)).BeginInit();
            this.RawLogPage.SuspendLayout();
            this.ActionLogPage.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.AnalysisPage);
            this.tabControl.Controls.Add(this.RawLogPage);
            this.tabControl.Controls.Add(this.ActionLogPage);
            this.tabControl.Controls.Add(this.SettingsTab);
            this.tabControl.Location = new System.Drawing.Point(0, 195);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1133, 491);
            this.tabControl.TabIndex = 4;
            // 
            // AnalysisPage
            // 
            this.AnalysisPage.Controls.Add(this.SpotAnalysisGrid);
            this.AnalysisPage.Location = new System.Drawing.Point(4, 25);
            this.AnalysisPage.Name = "AnalysisPage";
            this.AnalysisPage.Padding = new System.Windows.Forms.Padding(3);
            this.AnalysisPage.Size = new System.Drawing.Size(1125, 462);
            this.AnalysisPage.TabIndex = 0;
            this.AnalysisPage.Text = "Analysis";
            this.AnalysisPage.UseVisualStyleBackColor = true;
            // 
            // SpotAnalysisGrid
            // 
            this.SpotAnalysisGrid.AllowUserToAddRows = false;
            this.SpotAnalysisGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SpotAnalysisGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SpotAnalysisGrid.AutoGenerateColumns = false;
            this.SpotAnalysisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpotAnalysisGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.callDataGridViewTextBoxColumn,
            this.Value,
            this.Frequency,
            this.Band,
            this.Status,
            this.Comment,
            this.Mode,
            this.Zone,
            this.Country,
            this.PropogationRel,
            this.ValueModel,
            this.Timestamp,
            this.SpotterCall});
            this.SpotAnalysisGrid.DataSource = this.spotBindingSource;
            this.SpotAnalysisGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpotAnalysisGrid.Location = new System.Drawing.Point(3, 3);
            this.SpotAnalysisGrid.Name = "SpotAnalysisGrid";
            this.SpotAnalysisGrid.ReadOnly = true;
            this.SpotAnalysisGrid.RowTemplate.Height = 28;
            this.SpotAnalysisGrid.Size = new System.Drawing.Size(1119, 456);
            this.SpotAnalysisGrid.TabIndex = 4;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Value.DataPropertyName = "ValueString";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Value.DefaultCellStyle = dataGridViewCellStyle2;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 68;
            // 
            // Frequency
            // 
            this.Frequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Frequency.DataPropertyName = "Frequency";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Frequency.DefaultCellStyle = dataGridViewCellStyle3;
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            this.Frequency.Width = 97;
            // 
            // Band
            // 
            this.Band.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Band.DataPropertyName = "Band";
            this.Band.HeaderText = "Band";
            this.Band.Name = "Band";
            this.Band.ReadOnly = true;
            this.Band.Width = 65;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 62;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Visible = false;
            this.Comment.Width = 76;
            // 
            // Mode
            // 
            this.Mode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mode.DataPropertyName = "Mode";
            this.Mode.HeaderText = "Mode";
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            this.Mode.Visible = false;
            this.Mode.Width = 59;
            // 
            // Zone
            // 
            this.Zone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Zone.DataPropertyName = "Zone";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Zone.DefaultCellStyle = dataGridViewCellStyle4;
            this.Zone.HeaderText = "Zone";
            this.Zone.Name = "Zone";
            this.Zone.ReadOnly = true;
            this.Zone.Width = 64;
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 78;
            // 
            // PropogationRel
            // 
            this.PropogationRel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PropogationRel.DataPropertyName = "PropogationRel";
            this.PropogationRel.HeaderText = "PropogationRel";
            this.PropogationRel.Name = "PropogationRel";
            this.PropogationRel.ReadOnly = true;
            this.PropogationRel.Width = 128;
            // 
            // Timestamp
            // 
            this.Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Timestamp.DataPropertyName = "LocalTimestamp";
            this.Timestamp.HeaderText = "Local Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.Width = 125;
            // 
            // SpotterCall
            // 
            this.SpotterCall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SpotterCall.DataPropertyName = "SpotterCall";
            this.SpotterCall.HeaderText = "SpotterCall";
            this.SpotterCall.Name = "SpotterCall";
            this.SpotterCall.ReadOnly = true;
            this.SpotterCall.Width = 99;
            // 
            // RawLogPage
            // 
            this.RawLogPage.Controls.Add(this.RawXMLMessageLog);
            this.RawLogPage.Location = new System.Drawing.Point(4, 25);
            this.RawLogPage.Name = "RawLogPage";
            this.RawLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.RawLogPage.Size = new System.Drawing.Size(1125, 462);
            this.RawLogPage.TabIndex = 1;
            this.RawLogPage.Text = "Raw XML Message Log";
            this.RawLogPage.UseVisualStyleBackColor = true;
            // 
            // RawXMLMessageLog
            // 
            this.RawXMLMessageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RawXMLMessageLog.Location = new System.Drawing.Point(3, 3);
            this.RawXMLMessageLog.Multiline = true;
            this.RawXMLMessageLog.Name = "RawXMLMessageLog";
            this.RawXMLMessageLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RawXMLMessageLog.Size = new System.Drawing.Size(1119, 459);
            this.RawXMLMessageLog.TabIndex = 4;
            // 
            // ActionLogPage
            // 
            this.ActionLogPage.Controls.Add(this.ActionLog);
            this.ActionLogPage.Location = new System.Drawing.Point(4, 25);
            this.ActionLogPage.Name = "ActionLogPage";
            this.ActionLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.ActionLogPage.Size = new System.Drawing.Size(1125, 462);
            this.ActionLogPage.TabIndex = 2;
            this.ActionLogPage.Text = "Action Log";
            this.ActionLogPage.UseVisualStyleBackColor = true;
            // 
            // ActionLog
            // 
            this.ActionLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionLog.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLog.Location = new System.Drawing.Point(3, 3);
            this.ActionLog.Multiline = true;
            this.ActionLog.Name = "ActionLog";
            this.ActionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ActionLog.Size = new System.Drawing.Size(1119, 459);
            this.ActionLog.TabIndex = 5;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.label8);
            this.SettingsTab.Controls.Add(this.label7);
            this.SettingsTab.Controls.Add(this.label6);
            this.SettingsTab.Controls.Add(this.LongFrom);
            this.SettingsTab.Controls.Add(this.label5);
            this.SettingsTab.Controls.Add(this.LatFrom);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Controls.Add(this.TimezoneOffset);
            this.SettingsTab.Location = new System.Drawing.Point(4, 25);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(1125, 462);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Station Longitude";
            // 
            // LongFrom
            // 
            this.LongFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NM2O_Spot_Analyzer.Properties.Settings.Default, "LongFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LongFrom.Location = new System.Drawing.Point(188, 111);
            this.LongFrom.Name = "LongFrom";
            this.LongFrom.Size = new System.Drawing.Size(89, 22);
            this.LongFrom.TabIndex = 5;
            this.LongFrom.Text = global::NM2O_Spot_Analyzer.Properties.Settings.Default.LongFrom;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Station Latitude";
            // 
            // LatFrom
            // 
            this.LatFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NM2O_Spot_Analyzer.Properties.Settings.Default, "LatFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LatFrom.Location = new System.Drawing.Point(188, 73);
            this.LatFrom.Name = "LatFrom";
            this.LatFrom.Size = new System.Drawing.Size(89, 22);
            this.LatFrom.TabIndex = 3;
            this.LatFrom.Text = global::NM2O_Spot_Analyzer.Properties.Settings.Default.LatFrom;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timezone Offset";
            // 
            // TimezoneOffset
            // 
            this.TimezoneOffset.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NM2O_Spot_Analyzer.Properties.Settings.Default, "TimeZoneOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimezoneOffset.Location = new System.Drawing.Point(188, 35);
            this.TimezoneOffset.Name = "TimezoneOffset";
            this.TimezoneOffset.Size = new System.Drawing.Size(89, 22);
            this.TimezoneOffset.TabIndex = 1;
            this.TimezoneOffset.Text = global::NM2O_Spot_Analyzer.Properties.Settings.Default.TimeZoneOffset;
            this.TimezoneOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnter_NoDing);
            this.TimezoneOffset.Validating += new System.ComponentModel.CancelEventHandler(this.TimezoneOffset_Validating);
            // 
            // AllSpotsLabel
            // 
            this.AllSpotsLabel.AutoSize = true;
            this.AllSpotsLabel.Location = new System.Drawing.Point(21, 19);
            this.AllSpotsLabel.Name = "AllSpotsLabel";
            this.AllSpotsLabel.Size = new System.Drawing.Size(61, 16);
            this.AllSpotsLabel.TabIndex = 6;
            this.AllSpotsLabel.Text = "All Spots";
            // 
            // AllSpots
            // 
            this.AllSpots.AutoSize = true;
            this.AllSpots.Location = new System.Drawing.Point(140, 20);
            this.AllSpots.Name = "AllSpots";
            this.AllSpots.Size = new System.Drawing.Size(36, 16);
            this.AllSpots.TabIndex = 6;
            this.AllSpots.Text = "1000";
            this.AllSpots.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DisplaySpots
            // 
            this.DisplaySpots.AutoSize = true;
            this.DisplaySpots.Location = new System.Drawing.Point(140, 51);
            this.DisplaySpots.Name = "DisplaySpots";
            this.DisplaySpots.Size = new System.Drawing.Size(36, 16);
            this.DisplaySpots.TabIndex = 7;
            this.DisplaySpots.Text = "1000";
            this.DisplaySpots.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DisplaySpotsLabel
            // 
            this.DisplaySpotsLabel.AutoSize = true;
            this.DisplaySpotsLabel.Location = new System.Drawing.Point(21, 50);
            this.DisplaySpotsLabel.Name = "DisplaySpotsLabel";
            this.DisplaySpotsLabel.Size = new System.Drawing.Size(108, 16);
            this.DisplaySpotsLabel.TabIndex = 8;
            this.DisplaySpotsLabel.Text = "Displayed Spots";
            // 
            // RadioBandsListBox
            // 
            this.RadioBandsListBox.FormattingEnabled = true;
            this.RadioBandsListBox.ItemHeight = 16;
            this.RadioBandsListBox.Location = new System.Drawing.Point(416, 44);
            this.RadioBandsListBox.Name = "RadioBandsListBox";
            this.RadioBandsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.RadioBandsListBox.Size = new System.Drawing.Size(211, 132);
            this.RadioBandsListBox.TabIndex = 9;
            this.RadioBandsListBox.SelectedIndexChanged += new System.EventHandler(this.RefreshData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Spotted Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Radio Band";
            // 
            // SpottedModeListBox
            // 
            this.SpottedModeListBox.FormattingEnabled = true;
            this.SpottedModeListBox.ItemHeight = 16;
            this.SpottedModeListBox.Location = new System.Drawing.Point(193, 44);
            this.SpottedModeListBox.Name = "SpottedModeListBox";
            this.SpottedModeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SpottedModeListBox.Size = new System.Drawing.Size(211, 132);
            this.SpottedModeListBox.TabIndex = 12;
            this.SpottedModeListBox.SelectedIndexChanged += new System.EventHandler(this.RefreshData);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn1.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // loadPropButton
            // 
            this.loadPropButton.Location = new System.Drawing.Point(634, 44);
            this.loadPropButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadPropButton.Name = "loadPropButton";
            this.loadPropButton.Size = new System.Drawing.Size(100, 28);
            this.loadPropButton.TabIndex = 13;
            this.loadPropButton.Text = "Load Prop";
            this.loadPropButton.UseVisualStyleBackColor = true;
            this.loadPropButton.Click += new System.EventHandler(this.LoadPropButton_Click);
            // 
            // RunPropButton
            // 
            this.RunPropButton.Location = new System.Drawing.Point(634, 80);
            this.RunPropButton.Margin = new System.Windows.Forms.Padding(4);
            this.RunPropButton.Name = "RunPropButton";
            this.RunPropButton.Size = new System.Drawing.Size(100, 28);
            this.RunPropButton.TabIndex = 14;
            this.RunPropButton.Text = "Run Prop";
            this.RunPropButton.UseVisualStyleBackColor = true;
            this.RunPropButton.Click += new System.EventHandler(this.RunPropButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Propogation";
            // 
            // PropDateLabel
            // 
            this.PropDateLabel.AutoSize = true;
            this.PropDateLabel.Location = new System.Drawing.Point(745, 49);
            this.PropDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PropDateLabel.Name = "PropDateLabel";
            this.PropDateLabel.Size = new System.Drawing.Size(66, 16);
            this.PropDateLabel.TabIndex = 16;
            this.PropDateLabel.Text = "PropDate";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn6.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn7.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn8.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 300;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn9.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 300;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn10.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ValueModel";
            this.dataGridViewTextBoxColumn11.HeaderText = "Value Model";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Format like \'42.65N\'";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Format like \'73.75W\'";
            // 
            // callDataGridViewTextBoxColumn
            // 
            this.callDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.callDataGridViewTextBoxColumn.DataPropertyName = "Call";
            this.callDataGridViewTextBoxColumn.HeaderText = "Call";
            this.callDataGridViewTextBoxColumn.Name = "callDataGridViewTextBoxColumn";
            this.callDataGridViewTextBoxColumn.ReadOnly = true;
            this.callDataGridViewTextBoxColumn.Width = 56;
            // 
            // ValueModel
            // 
            this.ValueModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValueModel.DataPropertyName = "ValueModel";
            this.ValueModel.HeaderText = "Value Model";
            this.ValueModel.Name = "ValueModel";
            this.ValueModel.ReadOnly = true;
            // 
            // spotBindingSource
            // 
            this.spotBindingSource.DataSource = typeof(NM2O_Spot_Analyzer.Spot);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 687);
            this.Controls.Add(this.PropDateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RunPropButton);
            this.Controls.Add(this.loadPropButton);
            this.Controls.Add(this.SpottedModeListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadioBandsListBox);
            this.Controls.Add(this.DisplaySpots);
            this.Controls.Add(this.DisplaySpotsLabel);
            this.Controls.Add(this.AllSpots);
            this.Controls.Add(this.AllSpotsLabel);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NM2O Spot Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.tabControl.ResumeLayout(false);
            this.AnalysisPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpotAnalysisGrid)).EndInit();
            this.RawLogPage.ResumeLayout(false);
            this.RawLogPage.PerformLayout();
            this.ActionLogPage.ResumeLayout(false);
            this.ActionLogPage.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource spotBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn myPropertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage AnalysisPage;
        private System.Windows.Forms.TabPage RawLogPage;
        private System.Windows.Forms.DataGridView SpotAnalysisGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox RawXMLMessageLog;
        private System.Windows.Forms.TabPage ActionLogPage;
        private System.Windows.Forms.TextBox ActionLog;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TextBox TimezoneOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AllSpotsLabel;
        private System.Windows.Forms.Label AllSpots;
        private System.Windows.Forms.Label DisplaySpots;
        private System.Windows.Forms.Label DisplaySpotsLabel;
        private System.Windows.Forms.ListBox RadioBandsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox SpottedModeListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button loadPropButton;
        private System.Windows.Forms.Button RunPropButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PropDateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Band;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropogationRel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpotterCall;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LongFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LatFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

