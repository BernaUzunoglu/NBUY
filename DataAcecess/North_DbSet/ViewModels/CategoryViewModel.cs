using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North_DbSet.ViewModels
{
    public class CategoryViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public int ProductCount { get; set; } = 0;
    }
}
