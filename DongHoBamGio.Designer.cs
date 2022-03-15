namespace FormBamGio
{
    partial class DongHoBamGio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtHourMinSec = new System.Windows.Forms.TextBox();
            this.txtMiliSec = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHourMinSec
            // 
            this.txtHourMinSec.Location = new System.Drawing.Point(18, 40);
            this.txtHourMinSec.MaxLength = 8;
            this.txtHourMinSec.Multiline = true;
            this.txtHourMinSec.Name = "txtHourMinSec";
            this.txtHourMinSec.Size = new System.Drawing.Size(132, 19);
            this.txtHourMinSec.TabIndex = 0;
            this.txtHourMinSec.Text = "00:00:00";
            this.txtHourMinSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMiliSec
            // 
            this.txtMiliSec.Location = new System.Drawing.Point(206, 40);
            this.txtMiliSec.MaxLength = 3;
            this.txtMiliSec.Multiline = true;
            this.txtMiliSec.Name = "txtMiliSec";
            this.txtMiliSec.Size = new System.Drawing.Size(46, 17);
            this.txtMiliSec.TabIndex = 2;
            this.txtMiliSec.Text = "000";
            this.txtMiliSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(61, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(177, 107);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(75, 23);
            this.btnLap.TabIndex = 6;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // DongHoBamGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMiliSec);
            this.Controls.Add(this.txtHourMinSec);
            this.Name = "DongHoBamGio";
            this.Size = new System.Drawing.Size(307, 150);
            this.Load += new System.EventHandler(this.DongHoBamGio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHourMinSec;
        private System.Windows.Forms.TextBox txtMiliSec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
