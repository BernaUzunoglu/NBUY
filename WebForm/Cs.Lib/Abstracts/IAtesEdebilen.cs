using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public interface IAtesEdebilen
    {
        int AtesEt();
        Stream AtisSesi { get; }
        Stream BitikFisekSesi { get; }

    }
}
