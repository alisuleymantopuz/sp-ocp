using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario2
{
    public class ShoppingCartTest
    {
        public void Usage()
        {

            var discountRules = new List<IDiscountRule>
                    {
                        new DiscountRuleNoDiscount(), 
                        new DiscountRuleTenItems(), 
                    };

            var discountCalculator = new DiscountCalculator(discountRules);

            var shoppingCart = new ShoppingCart(discountCalculator, new List<CartItem>());

            for (int i = 0; i < 12; i++)
            {
                shoppingCart.Add(new CartItem());
            }

          
            Console.WriteLine("{0} items gives us a {1}% discount",
                            shoppingCart.CartItems.Count,
                            shoppingCart.GetDiscountPercentage());


            Console.ReadLine();
        }
    }
}
