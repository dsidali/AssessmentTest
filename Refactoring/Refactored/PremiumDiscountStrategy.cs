using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Refactored
{
    internal class PremiumDiscountStrategy:IDiscountStrategy
    {
        public decimal CalculateStrategy(Product product)
        {  
          
         

            if (product.Price > 100) return 0.1m;
            if (product.Price > 50) return 0.05m;
            if (product.Price > 10) return 0.02m;
            
            return 0;

            // Can also be done using swith-case just like this
            /*
            switch (product.Price)
            {
                case > 100:
                    return 0.1m;
                case > 50:
                    return 0.05m;
                case > 10:
                    return 0.02m;
                default:
                    return 0m;
            }
            */


        }
    }
}
