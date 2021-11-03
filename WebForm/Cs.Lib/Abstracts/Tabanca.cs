using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {

        protected int _sarjorKapasitesi,_kalanFisek;
        protected Stream _atisSesi, _bitikFisekSesi, _yenidenDoldurmaSesi;

        // public int SarjorKapasitesi { get; }// 1.Yol
        public int SarjorKapasitesi => _sarjorKapasitesi;//Bu şekilde de sadece okunabilir property tanımı yapılır 2.Yol Readonly prop
        public int KalanFisek => _kalanFisek;

        public Stream AtisSesi => _atisSesi;

        public Stream BitikFisekSesi => _bitikFisekSesi;

        public Stream YenidenDoldurmaSesi => _yenidenDoldurmaSesi;

        public abstract int AtesEt();

        public abstract int YenidenDoldur();
        
    }
}
