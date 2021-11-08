
namespace MyCoin
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
            this.components = new System.ComponentModel.Container();
            this.lstExchange = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstExchange
            // 
            this.lstExchange.FormattingEnabled = true;
            this.lstExchange.ItemHeight = 15;
            this.lstExchange.Location = new System.Drawing.Point(45, 72);
            this.lstExchange.Name = "lstExchange";
            this.lstExchange.Size = new System.Drawing.Size(178, 319);
            this.lstExchange.TabIndex = 0;
            this.lstExchange.SelectedIndexChanged += new System.EventHandler(this.lstExchange_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(45, 23);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(178, 23);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstExchange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExchange;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Timer timer1;
    }
}

