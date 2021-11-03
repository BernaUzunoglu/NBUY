using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public interface IVurulabilir
    {
        Stream BicakCıkarma { get; }
        Stream BicakSaplama { get; }
        int VurusKatsayisi { get; }
        int Vur();
    }
}
