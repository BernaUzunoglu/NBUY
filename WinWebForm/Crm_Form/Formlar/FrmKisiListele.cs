using Crm_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm_Form.Formlar
{
    public partial class FrmKisiListele : Form
    {
        public FrmKisiListele()
        {
            InitializeComponent();
        }
        public Kisi SeciliKisi { get; set; }
        public List<Kisi> Kisiler { get; set; }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            SeciliKisi = lstKisiler.SelectedItem as Kisi;

        }

        private void FrmKisiListele_Load(object sender, EventArgs e)
        {
           lstKisiler.DataSource = Kisiler;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SeciliKisi == null)
            {
                MessageBox.Show("Bir kişi seçmediniz");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeciliKisi == null)
            {
                MessageBox.Show("Bir kişi seçmediniz");
                return;
            }

            var result = MessageBox.Show($"{SeciliKisi} kişisini silmek istiyor musunuz?","Kişi Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Kisiler.Remove(SeciliKisi);
                lstKisiler.SelectedIndex = -1;
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = Kisiler;
                SeciliKisi = null;
            }
        }
    }
}
