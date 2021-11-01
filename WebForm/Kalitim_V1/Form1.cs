using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Kare k1 = new Kare(10);
           Kare k2 = new Kare(5);
          
            Dikdörtgen d1 = new Dikdörtgen(3,4);
            Dikdörtgen d2 = new Dikdörtgen(5, 12);

            Daire da1 = new Daire(7);
            Daire da2 = new Daire(8);

            DikUcgen u1 = new DikUcgen(6, 8);
            DikUcgen u2 = new DikUcgen(10, 24);


            lstSekiller.Items.Add(k1);
            lstSekiller.Items.Add(k2);
            lstSekiller.Items.Add(d1);
            lstSekiller.Items.Add(d2);
            lstSekiller.Items.Add(da1);
            lstSekiller.Items.Add(da2);
            lstSekiller.Items.Add(u1);
            lstSekiller.Items.Add(u2);

        }

        private void lstSekiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSekiller.SelectedItem == null) return;

            // Sekil seciliSekil = lstSekiller.SelectedItem as Sekil;

            /*POLYMORPHİZM --- Çok biçimlilik örneği 
             *Kod kalabalığını önler
             *Sürdürülebilir bir yazım oluşturulur.
             ** Aynı işi yapan farklı nesneleri yönetmek için kullanılır. Ödeme sistemi gibi
             */
            Sekil seciliSekil = (Sekil)lstSekiller.SelectedItem ;
            
            if(seciliSekil is Kare)
            {

            }
            else if(seciliSekil is Dikdörtgen)
            {
                Dikdörtgen dd = seciliSekil as Dikdörtgen;
            }
            else if(seciliSekil is Daire dd)//Daire içindeki özel metotları çağırmak için Darie tipinde dd adında nesne ile ulaşabiliyoruz.
            {
                this.Text = dd.Cap().ToString();
            }


            lblDetay.Text = 
                $"Alanı :{seciliSekil.AlanHesapla()}\n Cevre Hesap : {seciliSekil.CevreHesapla()}\n Köşegen uzunluğu : {seciliSekil.KosegenHesapla()}";

        }
    }
}
