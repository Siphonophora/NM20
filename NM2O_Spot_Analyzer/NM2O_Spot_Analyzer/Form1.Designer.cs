namespace NM2O_Spot_Analyzer
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.output = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.textUDPScroll = new System.Windows.Forms.TextBox();
            this.SpotAnalysisGrid = new System.Windows.Forms.DataGridView();
            this.callDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spotBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpotAnalysisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(126, 57);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(101, 26);
            this.output.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(359, 57);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(144, 52);
            this.button.TabIndex = 1;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textUDPScroll
            // 
            this.textUDPScroll.Location = new System.Drawing.Point(1198, 954);
            this.textUDPScroll.Multiline = true;
            this.textUDPScroll.Name = "textUDPScroll";
            this.textUDPScroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textUDPScroll.Size = new System.Drawing.Size(607, 236);
            this.textUDPScroll.TabIndex = 2;
            // 
            // SpotAnalysisGrid
            // 
            this.SpotAnalysisGrid.AllowUserToOrderColumns = true;
            this.SpotAnalysisGrid.AutoGenerateColumns = false;
            this.SpotAnalysisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpotAnalysisGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.callDataGridViewTextBoxColumn,
            this.valDataGridViewTextBoxColumn});
            this.SpotAnalysisGrid.DataSource = this.spotBindingSource;
            this.SpotAnalysisGrid.Location = new System.Drawing.Point(126, 191);
            this.SpotAnalysisGrid.Name = "SpotAnalysisGrid";
            this.SpotAnalysisGrid.RowTemplate.Height = 28;
            this.SpotAnalysisGrid.Size = new System.Drawing.Size(1776, 604);
            this.SpotAnalysisGrid.TabIndex = 3;
            // 
            // callDataGridViewTextBoxColumn
            // 
            this.callDataGridViewTextBoxColumn.DataPropertyName = "Call";
            this.callDataGridViewTextBoxColumn.HeaderText = "Call";
            this.callDataGridViewTextBoxColumn.Name = "callDataGridViewTextBoxColumn";
            // 
            // valDataGridViewTextBoxColumn
            // 
            this.valDataGridViewTextBoxColumn.DataPropertyName = "Val";
            this.valDataGridViewTextBoxColumn.HeaderText = "Val";
            this.valDataGridViewTextBoxColumn.Name = "valDataGridViewTextBoxColumn";
            // 
            // spotBindingSource
            // 
            this.spotBindingSource.DataSource = typeof(NM2O_Spot_Analyzer.Spot);
            // 
            // spotBindingSource1
            // 
            this.spotBindingSource1.DataSource = typeof(NM2O_Spot_Analyzer.Spot);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2353, 1317);
            this.Controls.Add(this.SpotAnalysisGrid);
            this.Controls.Add(this.textUDPScroll);
            this.Controls.Add(this.button);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.SpotAnalysisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textUDPScroll;
        private System.Windows.Forms.DataGridView SpotAnalysisGrid;
        private System.Windows.Forms.BindingSource spotBindingSource;
        private System.Windows.Forms.BindingSource spotBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn myPropertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDataGridViewTextBoxColumn;
    }
}

