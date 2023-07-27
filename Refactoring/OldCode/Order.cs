using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.OldCode
{
    internal class Order
    {
        public void Checkout(IEnumerable<Product> products, Customer customer)
        {

            if (customer.IsPremium)
            {
                foreach (var product in products)
                {
                    if (product.Price > 100)
                    {
                        product.ApplyDiscount(new Discount(0.1m));
                    }
                    else if (product.Price > 50 && product.Price <= 100)
                    {
                        product.ApplyDiscount(new Discount(0.05m));
                    }
                    else if (product.Price > 10 && product.Price <= 50)
                    {
                        product.ApplyDiscount(new Discount(0.02m));
                    }


                }

            }
            else
            {
                foreach (var product in products)
                {
                    if (product.Price > 100)
                    {
                        product.ApplyDiscount(new Discount(0.05m));
                    }
                    else if (product.Price > 50 && product.Price <= 100)
                    {
                        product.ApplyDiscount(new Discount(0.03m));
                    }
                    else if (product.Price > 10 && product.Price <= 50)
                    {
                        product.ApplyDiscount(new Discount(0.01m));
                    }


                }
            }


        }
    }
}
