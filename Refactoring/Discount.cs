using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal class Discount
    {
        public Decimal DiscountAmount { get; set; }

        public Discount(decimal amontDiscountAmount)
        {
            DiscountAmount = amontDiscountAmount;
        }
    }
}
