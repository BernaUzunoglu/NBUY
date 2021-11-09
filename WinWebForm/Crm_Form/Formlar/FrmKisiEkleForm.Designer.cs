
namespace Crm_Form.Formlar
{
    partial class FrmKisiEkleForm
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
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(334, 114);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiEkle.TabIndex = 0;
            this.btnKisiEkle.Text = "button1";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // FrmKisiEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKisiEkle);
            this.Name = "FrmKisiEkleForm";
            this.Text = "FrmKisiEkleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKisiEkle;
    }
}