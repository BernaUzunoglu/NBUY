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
    public sealed class Bıcak:YakinSaldiri
    {
        public Bıcak()
        {
            
            this.Ulke = "Irak";
            this.Hasar = 24;
            this.Fiyat = 6700m;
            //this.VurusKatsayisi = 350;
            this._vurusKatsayisi = 35000;
            this.SilahResim = new MemoryStream(Properties.Resources.Bicak);
            this._bicakCikarma = Properties.Resources.Bicak_Cikarma;
            

        }

        public override int Vur()
        {
            this._bicakSaplama = Properties.Resources.Bicak_Saplama;
            Thread.Sleep(VurusKatsayisi);
            return Hasar;
        }
    }
}
