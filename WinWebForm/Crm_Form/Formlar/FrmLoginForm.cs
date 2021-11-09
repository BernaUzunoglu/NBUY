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
    public partial class FrmLoginForm : Form
    {
        public FrmLoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKulAdi.Text=="admin" && txtSifre.Text == "123")
            {
                MessageBox.Show("Hoşgeldin admin");

                Form1 anaform = new Form1();

                anaform.Show();
                this.Hide();
            }
        }
    }
}
