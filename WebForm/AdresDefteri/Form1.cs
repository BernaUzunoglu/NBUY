using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdresDefteri.Models;


namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kisi kisi = new Kisi();
        Ders ders = new Ders();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
               // kisi.Ad = "Berna";
                //kisi.Soyad = "U";
                //kisi.TcNo = "02345678911";
                //kisi.DogumTarihi = new DateTime(1985,05,20);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu",ex.Message);
                
            }
            //MessageBox.Show(kisi.Soyad);
            MessageBox.Show($"Kişinin yaşı :{kisi.Yas}"); //$ işareti ile başlayarak string format kullanılmıştır.
        }

        private List<Kisi> kisiler = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
                Kisi yeniKisi = new Kisi();
                try
                {
                    yeniKisi.Ad = txtAd.Text;
                    yeniKisi.Soyad = txtSoyad.Text;
                    yeniKisi.DogumTarihi = dtpDog_tar.Value;
                    yeniKisi.TcNo = txtTcno.Text;

                    kisiler.Add(yeniKisi);
                //lstbxKisiler.Items.Add(yeniKisi);

                //  kisi.OlusturulmaZamanı = DateTime.Now.AddDays(1);==> Bu satır hata verir çünkü propertyde private set tanımlaması yapılmıştır.

                ListeyiDoldur();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
  

        }

        private void ListeyiDoldur()
        {
            lstbxKisiler.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                lstbxKisiler.Items.Add(kisi1);
            }

        }

        private Kisi seciliKisi;

        private void lstbxKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxKisiler.SelectedItem == null) return;



            //seciliKisi =(Kisi)lstbxKisiler.SelectedItem;

            seciliKisi = lstbxKisiler.SelectedItem as Kisi;

            //txtAd.Text=$"Adı :{ seciliKisi.Ad}";
            //txtSoyad.Text = $"Soyadı: {seciliKisi.Soyad}";
            //txtTcno.Text = $"TC No : {seciliKisi.TcNo}";

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTcno.Text = seciliKisi.TcNo;
            dtpDog_tar.Value = seciliKisi.DogumTarihi;
        }

        private void btnGncl_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.TcNo = txtTcno.Text;
            seciliKisi.DogumTarihi = dtpDog_tar.Value;
            ListeyiDoldur();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            DialogResult cevap = MessageBox.Show($"{seciliKisi} yi silmek istiyor musunuz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                kisiler.Remove(seciliKisi);
                ListeyiDoldur();
            }
        }
    }
}
