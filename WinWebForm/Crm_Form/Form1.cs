using Crm_Form.Formlar;
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

namespace Crm_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result= MessageBox.Show("Programı kapatmak istiyormusunuz? ","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(result!= DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private FrmDisariAktar _frmDisariAktar;
        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kontrollü nesne üretimi ram üzerindeki nesnenin ikinci kez üretimini engeledik.
            if(_frmDisariAktar== null || _frmDisariAktar.IsDisposed)
                _frmDisariAktar = new FrmDisariAktar();
            _frmDisariAktar.MdiParent = this;
            _frmDisariAktar.Show();
        }

        private FrmIceriAktar _frmIceriAktar;
        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmIceriAktar == null || _frmIceriAktar.IsDisposed)
                _frmIceriAktar = new FrmIceriAktar();
            _frmIceriAktar.MdiParent = this;
            _frmIceriAktar.Show();
        }

        public List<Kisi> Kisiler { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            var context = new Context();
            Kisiler = context.Kisiler;
            Console.WriteLine();
        }

        private FrmKisiEkleForm _frmKisiEkleForm;
        private void kişilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiEkleForm == null || _frmKisiEkleForm.IsDisposed)
                _frmKisiEkleForm = new FrmKisiEkleForm();
            _frmKisiEkleForm.MdiParent = this;
            _frmKisiEkleForm.Show();
        }

        private FrmKisiGuncelle _frmKisiGuncelle;
        private void kisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiGuncelle == null || _frmKisiGuncelle.IsDisposed)
                _frmKisiGuncelle = new FrmKisiGuncelle();
            _frmKisiGuncelle.Kisi = Kisiler.Last();
            _frmKisiGuncelle.MdiParent = this;
            _frmKisiGuncelle.Show();
        }
    }
}
