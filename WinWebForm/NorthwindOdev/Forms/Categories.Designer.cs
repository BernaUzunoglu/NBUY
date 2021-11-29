namespace NorthwindOdev.Forms
{
    partial class Categories
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
            this.dtgvKategori = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pboxResim = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategoriTanım = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnurunGit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(1097, 28);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(164, 68);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dtgvKategori
            // 
            this.dtgvKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKategori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvKategori.BackgroundColor = System.Drawing.Color.White;
            this.dtgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKategori.Location = new System.Drawing.Point(669, 111);
            this.dtgvKategori.MultiSelect = false;
            this.dtgvKategori.Name = "dtgvKategori";
            this.dtgvKategori.RowHeadersWidth = 51;
            this.dtgvKategori.RowTemplate.Height = 29;
            this.dtgvKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKategori.Size = new System.Drawing.Size(592, 381);
            this.dtgvKategori.TabIndex = 16;
            this.dtgvKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKategori_CellClick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(669, 521);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 164);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pboxResim
            // 
            this.pboxResim.Location = new System.Drawing.Point(234, 238);
            this.pboxResim.Name = "pboxResim";
            this.pboxResim.Size = new System.Drawing.Size(252, 213);
            this.pboxResim.TabIndex = 14;
            this.pboxResim.TabStop = false;
            this.pboxResim.Click += new System.EventHandler(this.pboxResim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategori Resim";
            // 
            // txtKategoriTanım
            // 
            this.txtKategoriTanım.Location = new System.Drawing.Point(234, 141);
            this.txtKategoriTanım.Name = "txtKategoriTanım";
            this.txtKategoriTanım.Size = new System.Drawing.Size(252, 27);
            this.txtKategoriTanım.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategori Tanım";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(234, 59);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(252, 27);
            this.txtKategoriAdi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "KategoriAdi";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(261, 488);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(164, 68);
            this.btn_Guncelle.TabIndex = 19;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(480, 488);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(164, 68);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(723, 52);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(252, 27);
            this.txtAra.TabIndex = 22;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "ARA";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(30, 488);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 68);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnurunGit
            // 
            this.btnurunGit.Location = new System.Drawing.Point(471, 617);
            this.btnurunGit.Name = "btnurunGit";
            this.btnurunGit.Size = new System.Drawing.Size(164, 68);
            this.btnurunGit.TabIndex = 24;
            this.btnurunGit.Text = "ÜRÜN İŞLEMLERİ";
            this.btnurunGit.UseVisualStyleBackColor = true;
            this.btnurunGit.Click += new System.EventHandler(this.btnurunGit_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 742);
            this.Controls.Add(this.btnurunGit);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtgvKategori);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pboxResim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKategoriTanım);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnListele;
        private ListView listView1;
        private PictureBox pboxResim;
        private Label label3;
        private TextBox txtKategoriTanım;
        private Label label2;
        private TextBox txtKategoriAdi;
        private Label label1;
        public DataGridView dtgvKategori;
        private Button btn_Guncelle;
        private Button btnSil;
        private TextBox txtAra;
        private Label label4;
        private Button btnEkle;
        private Button btnurunGit;
    }
}