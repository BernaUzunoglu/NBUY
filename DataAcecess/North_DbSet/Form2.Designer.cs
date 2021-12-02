namespace North_DbSet
{
    partial class Form2
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
            this.dgvNorth = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.lblSayfa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNorth)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNorth
            // 
            this.dgvNorth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNorth.Location = new System.Drawing.Point(56, 101);
            this.dgvNorth.Name = "dgvNorth";
            this.dgvNorth.RowHeadersWidth = 51;
            this.dgvNorth.RowTemplate.Height = 29;
            this.dgvNorth.Size = new System.Drawing.Size(896, 496);
            this.dgvNorth.TabIndex = 1;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(134, 19);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(148, 64);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(524, 19);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(148, 64);
            this.btnIleri.TabIndex = 3;
            this.btnIleri.Text = "İLERİ";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Location = new System.Drawing.Point(361, 41);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(50, 20);
            this.lblSayfa.TabIndex = 4;
            this.lblSayfa.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 609);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgvNorth);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNorth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNorth;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Label lblSayfa;
    }
}