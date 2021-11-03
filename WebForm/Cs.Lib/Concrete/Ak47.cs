using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public sealed class Ak47:Tufek
    {
        public Ak47()
        {
            this._atisKatsayisi = 250;
            this._sarjorKapasitesi = 30;
            this.Ulke = "Rusya";
            this.Hasar = 24;
            this.Fiyat = 2700m;
            this._kalanFisek = this.SarjorKapasitesi;
            this.SilahResim = new MemoryStream(Properties.Resources.Ak47);
            this._atisSesi = Properties.Resources.Ak47_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.Ak47_Reload;
        }

        public override int AtesEt()
        {
            if (KalanFisek != 0)
            {
                this._kalanFisek--;
            }
            Thread.Sleep(300);
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            this._kalanFisek = this.SarjorKapasitesi;
            Thread.Sleep(1000);
            return KalanFisek;
        }
    }
}
