namespace NorthwindOdev.Forms
{
    partial class Products
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
            this.btnListele = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTedar = new System.Windows.Forms.ComboBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSiparis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYeniSiparis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chxBxDurdur = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dtgridUrun = new System.Windows.Forms.DataGridView();
            this.btnCalisanGit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(927, 289);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(184, 63);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(163, 92);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(215, 28);
            this.cmbKategori.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(163, 30);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(215, 27);
            this.txt_UrunAdi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tedarikçi";
            // 
            // cmbTedar
            // 
            this.cmbTedar.FormattingEnabled = true;
            this.cmbTedar.Location = new System.Drawing.Point(163, 156);
            this.cmbTedar.Name = "cmbTedar";
            this.cmbTedar.Size = new System.Drawing.Size(215, 28);
            this.cmbTedar.TabIndex = 6;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(163, 223);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(215, 27);
            this.txtBirim.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birim Miktar";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(163, 282);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(215, 27);
            this.txtFiyat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birim Fiyat";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(616, 30);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(215, 27);
            this.txtStok.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birim Stok";
            // 
            // txtSiparis
            // 
            this.txtSiparis.Location = new System.Drawing.Point(616, 87);
            this.txtSiparis.Name = "txtSiparis";
            this.txtSiparis.Size = new System.Drawing.Size(215, 27);
            this.txtSiparis.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birim Sipariş";
            // 
            // txtYeniSiparis
            // 
            this.txtYeniSiparis.Location = new System.Drawing.Point(616, 155);
            this.txtYeniSiparis.Name = "txtYeniSiparis";
            this.txtYeniSiparis.Size = new System.Drawing.Size(215, 27);
            this.txtYeniSiparis.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Yeni Sipariş";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Durum";
            // 
            // chxBxDurdur
            // 
            this.chxBxDurdur.AutoSize = true;
            this.chxBxDurdur.Location = new System.Drawing.Point(616, 226);
            this.chxBxDurdur.Name = "chxBxDurdur";
            this.chxBxDurdur.Size = new System.Drawing.Size(77, 24);
            this.chxBxDurdur.TabIndex = 19;
            this.chxBxDurdur.Text = "Durdur";
            this.chxBxDurdur.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(927, 205);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(184, 63);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(927, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(184, 63);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(927, 119);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(184, 63);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dtgridUrun
            // 
            this.dtgridUrun.BackgroundColor = System.Drawing.Color.White;
            this.dtgridUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridUrun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgridUrun.GridColor = System.Drawing.Color.Silver;
            this.dtgridUrun.Location = new System.Drawing.Point(0, 417);
            this.dtgridUrun.Name = "dtgridUrun";
            this.dtgridUrun.RowHeadersWidth = 51;
            this.dtgridUrun.RowTemplate.Height = 29;
            this.dtgridUrun.Size = new System.Drawing.Size(1307, 303);
            this.dtgridUrun.TabIndex = 23;
            this.dtgridUrun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridUrun_CellClick);
            // 
            // btnCalisanGit
            // 
            this.btnCalisanGit.Location = new System.Drawing.Point(1165, 289);
            this.btnCalisanGit.Name = "btnCalisanGit";
            this.btnCalisanGit.Size = new System.Drawing.Size(130, 63);
            this.btnCalisanGit.TabIndex = 24;
            this.btnCalisanGit.Text = "ÇALIŞAN";
            this.btnCalisanGit.UseVisualStyleBackColor = true;
            this.btnCalisanGit.Click += new System.EventHandler(this.btnCalisanGit_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 720);
            this.Controls.Add(this.btnCalisanGit);
            this.Controls.Add(this.dtgridUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.chxBxDurdur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYeniSiparis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSiparis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTedar);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnListele);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnListele;
        private ComboBox cmbKategori;
        private Label label1;
        private Label label2;
        private TextBox txt_UrunAdi;
        private Label label3;
        private ComboBox cmbTedar;
        private TextBox txtBirim;
        private Label label4;
        private TextBox txtFiyat;
        private Label label5;
        private TextBox txtStok;
        private Label label6;
        private TextBox txtSiparis;
        private Label label7;
        private TextBox txtYeniSiparis;
        private Label label8;
        private Label label9;
        private CheckBox chxBxDurdur;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnSil;
        private DataGridView dtgridUrun;
        private Button btnCalisanGit;
    }
}