
namespace KisiEnvanteri
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGncl = new System.Windows.Forms.Button();
            this.lstbxKisiler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpDog_tar = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAKtarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.jSONDışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONİçeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(302, 298);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 31);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGncl
            // 
            this.btnGncl.Location = new System.Drawing.Point(168, 299);
            this.btnGncl.Name = "btnGncl";
            this.btnGncl.Size = new System.Drawing.Size(110, 30);
            this.btnGncl.TabIndex = 22;
            this.btnGncl.Text = "Güncelle";
            this.btnGncl.UseVisualStyleBackColor = true;
            this.btnGncl.Click += new System.EventHandler(this.btnGncl_Click);
            // 
            // lstbxKisiler
            // 
            this.lstbxKisiler.FormattingEnabled = true;
            this.lstbxKisiler.ItemHeight = 15;
            this.lstbxKisiler.Location = new System.Drawing.Point(491, 241);
            this.lstbxKisiler.Name = "lstbxKisiler";
            this.lstbxKisiler.Size = new System.Drawing.Size(256, 184);
            this.lstbxKisiler.TabIndex = 21;
            this.lstbxKisiler.SelectedIndexChanged += new System.EventHandler(this.lstbxKisiler_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(41, 298);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 31);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Tag = "";
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpDog_tar
            // 
            this.dtpDog_tar.Location = new System.Drawing.Point(168, 219);
            this.dtpDog_tar.Name = "dtpDog_tar";
            this.dtpDog_tar.Size = new System.Drawing.Size(200, 23);
            this.dtpDog_tar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Doğum Tarihi";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(168, 172);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 23);
            this.txtTel.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefon";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(168, 121);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 23);
            this.txtSoyad.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(168, 73);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 23);
            this.txtAd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(491, 76);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(205, 130);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 24;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dışarıAKtarToolStripMenuItem,
            this.içeriAktarToolStripMenuItem,
            this.toolStripSeparator1,
            this.jSONDışarıAktarToolStripMenuItem,
            this.jSONİçeriAktarToolStripMenuItem});
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            this.dosyaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dosyaİşlemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // dışarıAKtarToolStripMenuItem
            // 
            this.dışarıAKtarToolStripMenuItem.Name = "dışarıAKtarToolStripMenuItem";
            this.dışarıAKtarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dışarıAKtarToolStripMenuItem.Text = "XML Dışarı Aktar";
            this.dışarıAKtarToolStripMenuItem.Click += new System.EventHandler(this.dışarıAKtarToolStripMenuItem_Click);
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.içeriAktarToolStripMenuItem.Text = " XML İçeri Aktar";
            this.içeriAktarToolStripMenuItem.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // jSONDışarıAktarToolStripMenuItem
            // 
            this.jSONDışarıAktarToolStripMenuItem.Name = "jSONDışarıAktarToolStripMenuItem";
            this.jSONDışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.jSONDışarıAktarToolStripMenuItem.Text = "JSON Dışarı Aktar";
            this.jSONDışarıAktarToolStripMenuItem.Click += new System.EventHandler(this.jSONDışarıAktarToolStripMenuItem_Click);
            // 
            // jSONİçeriAktarToolStripMenuItem
            // 
            this.jSONİçeriAktarToolStripMenuItem.Name = "jSONİçeriAktarToolStripMenuItem";
            this.jSONİçeriAktarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.jSONİçeriAktarToolStripMenuItem.Text = "JSON İçeri Aktar";
            this.jSONİçeriAktarToolStripMenuItem.Click += new System.EventHandler(this.jSONİçeriAktarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGncl);
            this.Controls.Add(this.lstbxKisiler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpDog_tar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGncl;
        private System.Windows.Forms.ListBox lstbxKisiler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpDog_tar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAKtarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem jSONDışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONİçeriAktarToolStripMenuItem;
    }
}

