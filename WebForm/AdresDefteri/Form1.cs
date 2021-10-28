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
                lstbxKisiler.Items.Add(yeniKisi);

                //  kisi.OlusturulmaZamanı = DateTime.Now.AddDays(1);==> Bu satır hata verir çünkü propertyde private set tanımlaması yapılmıştır.


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
