
namespace Kalitim_V1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSekiller = new System.Windows.Forms.ListBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSekiller
            // 
            this.lstSekiller.FormattingEnabled = true;
            this.lstSekiller.ItemHeight = 15;
            this.lstSekiller.Location = new System.Drawing.Point(12, 21);
            this.lstSekiller.Name = "lstSekiller";
            this.lstSekiller.Size = new System.Drawing.Size(256, 379);
            this.lstSekiller.TabIndex = 0;
            this.lstSekiller.SelectedIndexChanged += new System.EventHandler(this.lstSekiller_SelectedIndexChanged);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Location = new System.Drawing.Point(305, 21);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(50, 15);
            this.lblDetay.TabIndex = 1;
            this.lblDetay.Text = "lblDetay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.lstSekiller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSekiller;
        private System.Windows.Forms.Label lblDetay;
    }
}

