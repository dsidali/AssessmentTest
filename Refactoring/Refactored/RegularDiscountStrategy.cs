using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Refactored
{
    internal class RegularDiscountStrategy:IDiscountStrategy
    {
        public decimal CalculateStrategy(Product product)
        {
            
            // Can also be done using swith-case


            if (product.Price > 100) return 0.05m;
            if (product.Price > 50) return 0.03m;
            if (product.Price > 10) return 0.01m;
          
            return 0m;

            // Can also be done using swith-case just like this
            /*
            switch (product.Price)
            {
                case > 100:
                    return 0.05m;
                case > 50:
                    return 0.03m;
                case > 10:
                    return 0.01m;
                default:
                    return 0m;
            }
            */


        }
    }
}
