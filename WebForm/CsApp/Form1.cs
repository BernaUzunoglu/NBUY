using Cs.Lib.Abstracts;
using Cs.Lib.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSilahlar.DataSource = Enum.GetNames(typeof(Silahlar));

            tmrseri.Tick += Tmrseri_Tick;//1.Yol
            //tmrseri.Tick= new EventHandler();
        }

        private void Tmrseri_Tick(object sender, EventArgs e)
        {
            btnAtesEt.PerformClick();
            System.Threading.Thread.Sleep(500);
        }

        private Silah silah;
        private Timer tmrseri = new Timer();
        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedItem == null) return;

            Silahlar seciliSilah = Enum.Parse<Silahlar>(cmbSilahlar.SelectedItem.ToString());

            switch (seciliSilah)
            {
                case Silahlar.Bıçak:
                    {
                        silah = new Bıcak();
                        SoundPlayer player = new SoundPlayer((silah as IVurulabilir).BicakCıkarma);
                        player.Play();
                        break;
                    }
                    
                case Silahlar.USP:
                    silah = new Usp();
                    break;
                case Silahlar.Glock:
                    silah = new Glock();
                    break;
                case Silahlar.DesertEagle:
                    silah = new DesertEagle();
                    break;
                case Silahlar.AK47:
                    silah = new Ak47();
                    break;
                case Silahlar.M4A1S:
                    silah = new M4a1s();
                    break;
                case Silahlar.AWP:
                    silah = new Awp();
                    break;
                case Silahlar.ElBombası:
                    silah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    silah = new FlashBombasi();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            if (silah == null) return;

            if(silah is IAtesEdebilen)
            {
                grpbxAtesliSilah.Visible = true;
                grpbxFirlatilan.Visible = false;
                grpbxYakinsaldiri.Visible = false;
            }
            else if(silah is IFirlatilabilen)
            {
                grpbxAtesliSilah.Visible = false;
                grpbxFirlatilan.Visible = true;
                grpbxYakinsaldiri.Visible = false;
            }
            else
            {
                grpbxAtesliSilah.Visible = false;
                grpbxFirlatilan.Visible = false;
                grpbxYakinsaldiri.Visible = true;
            }

            pnlSilah.Controls.Clear();
            PictureBox pbBox = new PictureBox();
            pbBox.Image = Image.FromStream(silah.SilahResim);
            pbBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBox.Dock = DockStyle.Fill;
            pnlSilah.Controls.Add(pbBox);
            SilahBilgisiGoster(silah);

        }

        private void SilahBilgisiGoster(Silah silah)
        {
            lblDetay.Text = $"Ülke: {silah.Ulke}\nFiyat: {silah.Fiyat:c2}";
            if (silah is ISarjorlu sarjorluSilahlar)
                lblDurum.Text = $"{sarjorluSilahlar.KalanFisek}/{sarjorluSilahlar.SarjorKapasitesi}";
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            btnAtesEt.Enabled = false;
            IAtesEdebilen atesliSilah = silah as IAtesEdebilen;
            int sayi = atesliSilah.AtesEt();
            SilahBilgisiGoster(silah);
            SoundPlayer player;

            if (sayi !=0)
            {
                player = new SoundPlayer(atesliSilah.AtisSesi);
                atesliSilah.AtisSesi.Position = 0;
            }
            else
            {
                player = new SoundPlayer(atesliSilah.BitikFisekSesi);
                atesliSilah.BitikFisekSesi.Position = 0;
            }
            player.Play();
            btnAtesEt.Enabled = true;
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            ISarjorlu atesliSilah = silah as ISarjorlu;
            atesliSilah.YenidenDoldur();
            SilahBilgisiGoster(silah);
            SoundPlayer player = new SoundPlayer(atesliSilah.YenidenDoldurmaSesi);
            atesliSilah.YenidenDoldurmaSesi.Position = 0;
            player.Play();

        }

        private void btnAtesEt_MouseDown(object sender, MouseEventArgs e)
        {
            if (silah is ISeriAtabilir ss)
            {
                tmrseri.Interval = ss.AtisKatsayisi;
                tmrseri.Start();
            }
        }

        private void btnAtesEt_MouseUp(object sender, MouseEventArgs e)
        {
            if (silah is ISeriAtabilir)
            {
                tmrseri.Stop();
            }
        }

        
        private void btnSaldir_Click(object sender, EventArgs e)
        {
            btnSaldir.Enabled = true;
            IVurulabilir vurulabilir = silah as IVurulabilir;
            (silah as IVurulabilir).Vur();
            SilahBilgisiGoster(silah);
            SoundPlayer player = new SoundPlayer(vurulabilir.BicakSaplama);
            player.Play();

        }

        private void btnFirlat_Click(object sender, EventArgs e)
        {
            btnFirlat.Enabled = true;
            IFirlatilabilen firlat = silah as IFirlatilabilen;
            //Firlatilan firlatilan = silah as Firlatilan;
           // firlatilan.Firlat();
            firlat.Firlat();
            SilahBilgisiGoster(silah);
            //SoundPlayer player = new SoundPlayer(firlatilan.Bomba);
            SoundPlayer player = new SoundPlayer(firlat.Bomba);
            player.Play();

        }
    }
}