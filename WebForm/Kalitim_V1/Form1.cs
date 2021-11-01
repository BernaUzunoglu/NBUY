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
            k1.X = 10;
            double kareAlani = k1.AlanHesapla();
            MessageBox.Show("Karenin alanı : "+kareAlani);

            Dikdörtgen d1 = new Dikdörtgen(3,4);
            double dikdörtgenAlani = d1.AlanHesapla();
            MessageBox.Show("Dikdörtgenin alanı : " + dikdörtgenAlani);

            //Sekil sekil1 = new Sekil(); Abstract olduğu için 
            //sekil1.X = 20;
            //double alan = sekil1.AlanHesapla();
            //MessageBox.Show("Sekil alanı : " + alan);

        }
    }
}
