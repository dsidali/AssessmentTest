using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Refactored
{
    internal class RefactoredOrder
    {
        public void Checkout(IEnumerable<Product> products, Customer customer)
        {

            IDiscountStrategy strategy;

            if (customer.IsPremium)
            {
                strategy = new PremiumDiscountStrategy();

            }
            else
            {
                strategy = new RegularDiscountStrategy();
            }

            foreach (var product in products)
            {
                var discount = new Discount(strategy.CalculateStrategy(product));
                product.ApplyDiscount(discount);
            }
        }
    }
}
