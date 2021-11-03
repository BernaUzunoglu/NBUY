using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Firlatilan : Silah, IFirlatilabilen
    {
        protected Stream _bomba;

        public Stream Bomba => _bomba;
        public abstract int Firlat();
    }
}
