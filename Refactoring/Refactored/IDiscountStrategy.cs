using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Refactored
{
    internal interface IDiscountStrategy
    {
        decimal CalculateStrategy(Product product);
    }
}
