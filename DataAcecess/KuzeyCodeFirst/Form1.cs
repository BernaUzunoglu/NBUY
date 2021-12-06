using KuzeyCodeFirst.Data;
using KuzeyCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private KuzeyContext _dbContext= new KuzeyContext();
        private void btneEkle_Click(object sender, EventArgs e)
        {
            _dbContext.Kategoriler.Add(new Kategori()
            {
                Ad = "Kategori",
                Aciklama ="Açıklama"
            });
            _dbContext.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var kategori = _dbContext.Kategoriler.First();
            kategori.Aciklama = "Güncel açıklama";
            _dbContext.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var kategori = _dbContext.Kategoriler.First();
            _dbContext.Kategoriler.Remove(kategori);
            _dbContext.SaveChanges();

        }
    }
}
