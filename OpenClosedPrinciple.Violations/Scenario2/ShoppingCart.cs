using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Violations.Scenario2
{
    public class ShoppingCart
    {
        private List<CartItem> _items;

        public decimal GetDiscountPercentage()
        {
            decimal ammount = 0;

            // Red flag!
            if (_items.Count >= 5 && _items.Count < 10)
            {
                ammount = 10;
            }
            else if (_items.Count >= 10 && _items.Count < 15)
            {
                ammount = 15;
            }
            else if (_items.Count >= 15)
            {
                ammount = 25;
            }

            return ammount;
        }

        public void Add(CartItem product)
        {
            // Add an item
        }

        public void Delete(CartItem product)
        {
            // Delete an item
        }
    }
}
