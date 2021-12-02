namespace North_DbSet
{
    partial class SiparisForm
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArttır = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListView();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbShippers = new System.Windows.Forms.ComboBox();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtshipCity = new System.Windows.Forms.TextBox();
            this.nFreight = new System.Windows.Forms.NumericUpDown();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFreight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(69, 32);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(242, 27);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(69, 90);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(242, 344);
            this.lstProducts.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(69, 453);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(242, 57);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(391, 453);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(121, 57);
            this.btnAzalt.TabIndex = 4;
            this.btnAzalt.Text = "AZALT";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(542, 453);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(121, 57);
            this.btnArttır.TabIndex = 5;
            this.btnArttır.Text = "ARTTIR";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(382, 28);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(161, 28);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "Toplam : 0.00 ₺";
            // 
            // lstCart
            // 
            this.lstCart.HideSelection = false;
            this.lstCart.Location = new System.Drawing.Point(391, 90);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(272, 344);
            this.lstCart.TabIndex = 7;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(872, 90);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(290, 28);
            this.cmbEmployee.TabIndex = 8;
            // 
            // cmbShippers
            // 
            this.cmbShippers.FormattingEnabled = true;
            this.cmbShippers.Location = new System.Drawing.Point(872, 179);
            this.cmbShippers.Name = "cmbShippers";
            this.cmbShippers.Size = new System.Drawing.Size(290, 28);
            this.cmbShippers.TabIndex = 9;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(872, 241);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(290, 27);
            this.dtpRequiredDate.TabIndex = 10;
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(872, 299);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(139, 27);
            this.txtShipAdress.TabIndex = 12;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(872, 352);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(139, 27);
            this.txtShipCountry.TabIndex = 13;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(872, 406);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(139, 27);
            this.txtShipPostalCode.TabIndex = 14;
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Location = new System.Drawing.Point(1023, 406);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(139, 27);
            this.txtShipRegion.TabIndex = 18;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(1023, 299);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(139, 27);
            this.txtShipName.TabIndex = 17;
            // 
            // txtshipCity
            // 
            this.txtshipCity.Location = new System.Drawing.Point(1023, 348);
            this.txtshipCity.Name = "txtshipCity";
            this.txtshipCity.Size = new System.Drawing.Size(139, 27);
            this.txtshipCity.TabIndex = 16;
            // 
            // nFreight
            // 
            this.nFreight.DecimalPlaces = 2;
            this.nFreight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nFreight.Location = new System.Drawing.Point(875, 469);
            this.nFreight.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nFreight.Name = "nFreight";
            this.nFreight.Size = new System.Drawing.Size(287, 34);
            this.nFreight.TabIndex = 19;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(931, 523);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(172, 57);
            this.btnOnayla.TabIndex = 20;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Çalışan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Teslimat Adres / Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ülke/Şehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Posta Kodu/ Bölge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Navlun";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Müşteri";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(872, 134);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(290, 28);
            this.cmbCustomers.TabIndex = 28;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 656);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.nFreight);
            this.Controls.Add(this.txtShipRegion);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.txtshipCity);
            this.Controls.Add(this.txtShipPostalCode);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.txtShipAdress);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.cmbShippers);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.txtAra);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFreight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ListView lstCart;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbShippers;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.TextBox txtShipAdress;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtshipCity;
        private System.Windows.Forms.NumericUpDown nFreight;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCustomers;
    }
}