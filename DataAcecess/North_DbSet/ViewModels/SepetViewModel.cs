using North_DbSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North_DbSet.ViewModels
{
    public class SepetViewModel
    {
        public Product  Urun { get; set; }
        public short Adet { get; set; } = 0;
        public decimal AraToplam => Urun.UnitPrice.GetValueOrDefault() * Adet;
    }
}
