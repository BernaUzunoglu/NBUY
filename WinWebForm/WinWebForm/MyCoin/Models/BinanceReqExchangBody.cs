using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Models
{
    public class BinanceReqExchangBody
    {
        public string timezone { get; set; }
        public long serverTime { get; set; }
        public RateLimit[] rateLimits { get; set; }
        public object[] exchangeFilters { get; set; }
        public List<Symbol> Symbols { get; set; } = new List<Symbol>();
    }

}

        

        

    