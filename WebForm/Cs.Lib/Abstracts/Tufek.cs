using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Tufek:Silah,ISarjorlu,IAtesEdebilen,ISeriAtabilir
    {
        protected int _sarjorKapasitesi, _kalanFisek,_atisKatsayisi;
        protected Stream _atisSesi, _bitikFisekSesi, _yenidenDoldurmaSesi;

        public int SarjorKapasitesi => _sarjorKapasitesi;//Readonly Prop
        public int KalanFisek => _kalanFisek;
        public int AtisKatsayisi => _atisKatsayisi;

        public Stream AtisSesi => _atisSesi;

        public Stream BitikFisekSesi => _bitikFisekSesi;

        public Stream YenidenDoldurmaSesi => _yenidenDoldurmaSesi;

        public abstract int AtesEt();

        public abstract int YenidenDoldur();
    }
}
