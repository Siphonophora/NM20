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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.output = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.textUDPScroll = new System.Windows.Forms.TextBox();
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
            this.textUDPScroll.Location = new System.Drawing.Point(105, 171);
            this.textUDPScroll.Multiline = true;
            this.textUDPScroll.Name = "textUDPScroll";
            this.textUDPScroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textUDPScroll.Size = new System.Drawing.Size(607, 236);
            this.textUDPScroll.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textUDPScroll);
            this.Controls.Add(this.button);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textUDPScroll;
    }
}

