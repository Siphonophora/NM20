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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AnalysisPage = new System.Windows.Forms.TabPage();
            this.SpotAnalysisGrid = new System.Windows.Forms.DataGridView();
            this.callDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Band = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpotterCall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RawLogPage = new System.Windows.Forms.TabPage();
            this.RawXMLMessageLog = new System.Windows.Forms.TextBox();
            this.ActionLogPage = new System.Windows.Forms.TabPage();
            this.ActionLog = new System.Windows.Forms.TextBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SevenMHz = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TimezoneOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllSpotsLabel = new System.Windows.Forms.Label();
            this.AllSpots = new System.Windows.Forms.Label();
            this.DisplaySpots = new System.Windows.Forms.Label();
            this.DisplaySpotsLabel = new System.Windows.Forms.Label();
            this.RadioBandsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpottedModeListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.AnalysisPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotAnalysisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource)).BeginInit();
            this.RawLogPage.SuspendLayout();
            this.ActionLogPage.SuspendLayout();
            this.SettingsTab.SuspendLayout();
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
            this.tabControl.Location = new System.Drawing.Point(0, 243);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2353, 1074);
            this.tabControl.TabIndex = 4;
            // 
            // AnalysisPage
            // 
            this.AnalysisPage.Controls.Add(this.SpotAnalysisGrid);
            this.AnalysisPage.Location = new System.Drawing.Point(4, 29);
            this.AnalysisPage.Name = "AnalysisPage";
            this.AnalysisPage.Padding = new System.Windows.Forms.Padding(3);
            this.AnalysisPage.Size = new System.Drawing.Size(2345, 1041);
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
            this.Timestamp,
            this.Comment,
            this.Mode,
            this.SpotterCall});
            this.SpotAnalysisGrid.DataSource = this.spotBindingSource;
            this.SpotAnalysisGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpotAnalysisGrid.Location = new System.Drawing.Point(3, 3);
            this.SpotAnalysisGrid.Name = "SpotAnalysisGrid";
            this.SpotAnalysisGrid.ReadOnly = true;
            this.SpotAnalysisGrid.RowTemplate.Height = 28;
            this.SpotAnalysisGrid.Size = new System.Drawing.Size(2339, 1035);
            this.SpotAnalysisGrid.TabIndex = 4;
            // 
            // callDataGridViewTextBoxColumn
            // 
            this.callDataGridViewTextBoxColumn.DataPropertyName = "Call";
            this.callDataGridViewTextBoxColumn.HeaderText = "Call";
            this.callDataGridViewTextBoxColumn.Name = "callDataGridViewTextBoxColumn";
            this.callDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Hours Last Contest";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.DataPropertyName = "Frequency";
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // Band
            // 
            this.Band.DataPropertyName = "Band";
            this.Band.HeaderText = "Band";
            this.Band.Name = "Band";
            this.Band.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Timestamp
            // 
            this.Timestamp.DataPropertyName = "LocalTimestamp";
            this.Timestamp.HeaderText = "Local Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // Mode
            // 
            this.Mode.DataPropertyName = "Mode";
            this.Mode.HeaderText = "Mode";
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            // 
            // SpotterCall
            // 
            this.SpotterCall.DataPropertyName = "SpotterCall";
            this.SpotterCall.HeaderText = "SpotterCall";
            this.SpotterCall.Name = "SpotterCall";
            this.SpotterCall.ReadOnly = true;
            // 
            // spotBindingSource
            // 
            this.spotBindingSource.DataSource = typeof(NM2O_Spot_Analyzer.Spot);
            // 
            // RawLogPage
            // 
            this.RawLogPage.Controls.Add(this.RawXMLMessageLog);
            this.RawLogPage.Location = new System.Drawing.Point(4, 29);
            this.RawLogPage.Name = "RawLogPage";
            this.RawLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.RawLogPage.Size = new System.Drawing.Size(2345, 1041);
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
            this.RawXMLMessageLog.Size = new System.Drawing.Size(2339, 1035);
            this.RawXMLMessageLog.TabIndex = 4;
            // 
            // ActionLogPage
            // 
            this.ActionLogPage.Controls.Add(this.ActionLog);
            this.ActionLogPage.Location = new System.Drawing.Point(4, 29);
            this.ActionLogPage.Name = "ActionLogPage";
            this.ActionLogPage.Padding = new System.Windows.Forms.Padding(3);
            this.ActionLogPage.Size = new System.Drawing.Size(2345, 1041);
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
            this.ActionLog.Size = new System.Drawing.Size(2339, 1035);
            this.ActionLog.TabIndex = 5;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.SevenMHz);
            this.SettingsTab.Controls.Add(this.checkedListBox1);
            this.SettingsTab.Controls.Add(this.checkBox1);
            this.SettingsTab.Controls.Add(this.TimezoneOffset);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Location = new System.Drawing.Point(4, 29);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(2345, 1041);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // SevenMHz
            // 
            this.SevenMHz.DataBindings.Add(new System.Windows.Forms.Binding("ValueMember", global::NM2O_Spot_Analyzer.Properties.Settings.Default, "SelectedBands", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SevenMHz.DisplayMember = "SevenMHz";
            this.SevenMHz.FormattingEnabled = true;
            this.SevenMHz.ItemHeight = 20;
            this.SevenMHz.Location = new System.Drawing.Point(1134, 316);
            this.SevenMHz.Name = "SevenMHz";
            this.SevenMHz.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SevenMHz.Size = new System.Drawing.Size(256, 224);
            this.SevenMHz.TabIndex = 4;
            this.SevenMHz.ValueMember = global::NM2O_Spot_Analyzer.Properties.Settings.Default.SelectedBands;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "asdf",
            "sf",
            "sf",
            "fsdf",
            "wf",
            "efwe"});
            this.checkedListBox1.Location = new System.Drawing.Point(400, 297);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(212, 214);
            this.checkedListBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(440, 189);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TimezoneOffset
            // 
            this.TimezoneOffset.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NM2O_Spot_Analyzer.Properties.Settings.Default, "TimeZoneOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimezoneOffset.Location = new System.Drawing.Point(284, 50);
            this.TimezoneOffset.Name = "TimezoneOffset";
            this.TimezoneOffset.Size = new System.Drawing.Size(100, 26);
            this.TimezoneOffset.TabIndex = 1;
            this.TimezoneOffset.Text = global::NM2O_Spot_Analyzer.Properties.Settings.Default.TimeZoneOffset;
            this.TimezoneOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEnter_NoDing);
            this.TimezoneOffset.Validating += new System.ComponentModel.CancelEventHandler(this.TimezoneOffset_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timezone Offset";
            // 
            // AllSpotsLabel
            // 
            this.AllSpotsLabel.AutoSize = true;
            this.AllSpotsLabel.Location = new System.Drawing.Point(36, 34);
            this.AllSpotsLabel.Name = "AllSpotsLabel";
            this.AllSpotsLabel.Size = new System.Drawing.Size(72, 20);
            this.AllSpotsLabel.TabIndex = 6;
            this.AllSpotsLabel.Text = "All Spots";
            // 
            // AllSpots
            // 
            this.AllSpots.AutoSize = true;
            this.AllSpots.Location = new System.Drawing.Point(169, 36);
            this.AllSpots.Name = "AllSpots";
            this.AllSpots.Size = new System.Drawing.Size(45, 20);
            this.AllSpots.TabIndex = 6;
            this.AllSpots.Text = "1000";
            this.AllSpots.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DisplaySpots
            // 
            this.DisplaySpots.AutoSize = true;
            this.DisplaySpots.Location = new System.Drawing.Point(169, 74);
            this.DisplaySpots.Name = "DisplaySpots";
            this.DisplaySpots.Size = new System.Drawing.Size(45, 20);
            this.DisplaySpots.TabIndex = 7;
            this.DisplaySpots.Text = "1000";
            this.DisplaySpots.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DisplaySpotsLabel
            // 
            this.DisplaySpotsLabel.AutoSize = true;
            this.DisplaySpotsLabel.Location = new System.Drawing.Point(36, 72);
            this.DisplaySpotsLabel.Name = "DisplaySpotsLabel";
            this.DisplaySpotsLabel.Size = new System.Drawing.Size(124, 20);
            this.DisplaySpotsLabel.TabIndex = 8;
            this.DisplaySpotsLabel.Text = "Displayed Spots";
            // 
            // RadioBandsListBox
            // 
            this.RadioBandsListBox.FormattingEnabled = true;
            this.RadioBandsListBox.ItemHeight = 20;
            this.RadioBandsListBox.Location = new System.Drawing.Point(512, 63);
            this.RadioBandsListBox.Name = "RadioBandsListBox";
            this.RadioBandsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.RadioBandsListBox.Size = new System.Drawing.Size(236, 164);
            this.RadioBandsListBox.TabIndex = 9;
            this.RadioBandsListBox.SelectedIndexChanged += new System.EventHandler(this.RefreshData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Spotted Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Radio Band";
            // 
            // SpottedModeListBox
            // 
            this.SpottedModeListBox.FormattingEnabled = true;
            this.SpottedModeListBox.ItemHeight = 20;
            this.SpottedModeListBox.Location = new System.Drawing.Point(261, 63);
            this.SpottedModeListBox.Name = "SpottedModeListBox";
            this.SpottedModeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SpottedModeListBox.Size = new System.Drawing.Size(236, 164);
            this.SpottedModeListBox.TabIndex = 12;
            this.SpottedModeListBox.SelectedIndexChanged += new System.EventHandler(this.RefreshData);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(903, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hours This Country THis band";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1053, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hours This Zone THis band";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1224, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Check boxes per band";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2353, 1317);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpottedModeListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadioBandsListBox);
            this.Controls.Add(this.DisplaySpots);
            this.Controls.Add(this.DisplaySpotsLabel);
            this.Controls.Add(this.AllSpots);
            this.Controls.Add(this.AllSpotsLabel);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "NM2O Spot Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.tabControl.ResumeLayout(false);
            this.AnalysisPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpotAnalysisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource)).EndInit();
            this.RawLogPage.ResumeLayout(false);
            this.RawLogPage.PerformLayout();
            this.ActionLogPage.ResumeLayout(false);
            this.ActionLogPage.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox SevenMHz;
        private System.Windows.Forms.Label AllSpotsLabel;
        private System.Windows.Forms.Label AllSpots;
        private System.Windows.Forms.Label DisplaySpots;
        private System.Windows.Forms.Label DisplaySpotsLabel;
        private System.Windows.Forms.ListBox RadioBandsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Band;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpotterCall;
        private System.Windows.Forms.ListBox SpottedModeListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

