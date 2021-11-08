using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Services
{
    public interface IBinanceReq<T> where T : class //Generic tipi class olan bir interface
    {
        string BaseUrl { get; }
        T Result(string param);
    }
}
