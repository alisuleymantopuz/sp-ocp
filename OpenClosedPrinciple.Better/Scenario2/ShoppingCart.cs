using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario2
{
    public class ShoppingCart
    {
        public List<CartItem> CartItems { get; private set; }
        public IDiscountCalculator DiscountCalculator { get; private set; }

        public ShoppingCart(IDiscountCalculator discountCalculator, List<CartItem> cartItems)
        {
            DiscountCalculator = discountCalculator;
            CartItems = cartItems;
        }

        public decimal GetDiscountPercentage()
        {
            return this.DiscountCalculator.Calculate(this.CartItems.Count);
        }

        public void Add(CartItem product)
        {
            this.CartItems.Add(product);
        }

        public void Delete(CartItem product)
        {
            // Delete an item
        }
    }
}
