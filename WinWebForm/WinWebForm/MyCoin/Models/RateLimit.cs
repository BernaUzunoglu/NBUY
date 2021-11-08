using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Models
{
    public class RateLimit
    {
        public string RateLimitType { get; set; }
        public string Interval { get; set; }
        public int IntervalNum { get; set; }
        public int Limit { get; set; }
    }
}
