namespace FormBamGio
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
            this.dongHoBamGio1 = new FormBamGio.DongHoBamGio();
            this.SuspendLayout();
            // 
            // dongHoBamGio1
            // 
            this.dongHoBamGio1.Location = new System.Drawing.Point(62, 12);
            this.dongHoBamGio1.Name = "dongHoBamGio1";
            this.dongHoBamGio1.Size = new System.Drawing.Size(307, 150);
            this.dongHoBamGio1.TabIndex = 0;
            this.dongHoBamGio1.Load += new System.EventHandler(this.dongHoBamGio1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 182);
            this.Controls.Add(this.dongHoBamGio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DongHoBamGio dongHoBamGio1;
    }
}

