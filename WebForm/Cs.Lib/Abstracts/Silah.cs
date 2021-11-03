using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Silah
    {

        public string Ulke { get; protected set; }
        public decimal Fiyat { get; protected set; }
        public int Hasar { get; protected set; }
        public Stream SilahResim { get; protected set; }
    }

    public enum Silahlar : byte
    {
        
        USP,
        Glock,
        DesertEagle,
        Bıçak,
        AK47,
        M4A1S,
        AWP,
        ElBombası,
        FlashBombası
    }
}
