using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal class Product
    {
        public int Price { get; set; }
        public void ApplyDiscount(Discount discount) { }
    }
}
