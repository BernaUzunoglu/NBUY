
namespace CsApp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.pnlSilah = new System.Windows.Forms.Panel();
            this.grpbxAtesliSilah = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.grpbxFirlatilan = new System.Windows.Forms.GroupBox();
            this.btnFirlat = new System.Windows.Forms.Button();
            this.grpbxYakinsaldiri = new System.Windows.Forms.GroupBox();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.lblDetay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxAtesliSilah.SuspendLayout();
            this.grpbxFirlatilan.SuspendLayout();
            this.grpbxYakinsaldiri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(140, 25);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(226, 23);
            this.cmbSilahlar.TabIndex = 0;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // pnlSilah
            // 
            this.pnlSilah.Location = new System.Drawing.Point(507, 39);
            this.pnlSilah.Name = "pnlSilah";
            this.pnlSilah.Size = new System.Drawing.Size(217, 127);
            this.pnlSilah.TabIndex = 1;
            // 
            // grpbxAtesliSilah
            // 
            this.grpbxAtesliSilah.Controls.Add(this.lblDurum);
            this.grpbxAtesliSilah.Controls.Add(this.btnDoldur);
            this.grpbxAtesliSilah.Controls.Add(this.btnAtesEt);
            this.grpbxAtesliSilah.Location = new System.Drawing.Point(37, 209);
            this.grpbxAtesliSilah.Name = "grpbxAtesliSilah";
            this.grpbxAtesliSilah.Size = new System.Drawing.Size(212, 139);
            this.grpbxAtesliSilah.TabIndex = 2;
            this.grpbxAtesliSilah.TabStop = false;
            this.grpbxAtesliSilah.Text = "Atesli Silah";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(126, 61);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(38, 15);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "label1";
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(6, 81);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(78, 42);
            this.btnDoldur.TabIndex = 1;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Location = new System.Drawing.Point(7, 23);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(78, 42);
            this.btnAtesEt.TabIndex = 0;
            this.btnAtesEt.Text = "Ates Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            this.btnAtesEt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseDown);
            this.btnAtesEt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtesEt_MouseUp);
            // 
            // grpbxFirlatilan
            // 
            this.grpbxFirlatilan.Controls.Add(this.btnFirlat);
            this.grpbxFirlatilan.Location = new System.Drawing.Point(305, 209);
            this.grpbxFirlatilan.Name = "grpbxFirlatilan";
            this.grpbxFirlatilan.Size = new System.Drawing.Size(200, 100);
            this.grpbxFirlatilan.TabIndex = 3;
            this.grpbxFirlatilan.TabStop = false;
            this.grpbxFirlatilan.Text = "Fırlatılan";
            // 
            // btnFirlat
            // 
            this.btnFirlat.Location = new System.Drawing.Point(19, 34);
            this.btnFirlat.Name = "btnFirlat";
            this.btnFirlat.Size = new System.Drawing.Size(78, 42);
            this.btnFirlat.TabIndex = 1;
            this.btnFirlat.Text = "Fırlat";
            this.btnFirlat.UseVisualStyleBackColor = true;
            this.btnFirlat.Click += new System.EventHandler(this.btnFirlat_Click);
            // 
            // grpbxYakinsaldiri
            // 
            this.grpbxYakinsaldiri.Controls.Add(this.btnSaldir);
            this.grpbxYakinsaldiri.Location = new System.Drawing.Point(550, 207);
            this.grpbxYakinsaldiri.Name = "grpbxYakinsaldiri";
            this.grpbxYakinsaldiri.Size = new System.Drawing.Size(200, 100);
            this.grpbxYakinsaldiri.TabIndex = 4;
            this.grpbxYakinsaldiri.TabStop = false;
            this.grpbxYakinsaldiri.Text = "Yakin Saldırı";
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(38, 36);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(78, 42);
            this.btnSaldir.TabIndex = 1;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Location = new System.Drawing.Point(44, 86);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(38, 15);
            this.lblDetay.TabIndex = 5;
            this.lblDetay.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Silah Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.grpbxYakinsaldiri);
            this.Controls.Add(this.grpbxFirlatilan);
            this.Controls.Add(this.grpbxAtesliSilah);
            this.Controls.Add(this.pnlSilah);
            this.Controls.Add(this.cmbSilahlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxAtesliSilah.ResumeLayout(false);
            this.grpbxAtesliSilah.PerformLayout();
            this.grpbxFirlatilan.ResumeLayout(false);
            this.grpbxYakinsaldiri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Panel pnlSilah;
        private System.Windows.Forms.GroupBox grpbxAtesliSilah;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.GroupBox grpbxFirlatilan;
        private System.Windows.Forms.Button btnFirlat;
        private System.Windows.Forms.GroupBox grpbxYakinsaldiri;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.Label label1;
    }
}

