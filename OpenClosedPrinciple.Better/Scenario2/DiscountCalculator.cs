using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario2
{
    public class DiscountCalculator : IDiscountCalculator
    {
        private readonly List<IDiscountRule> _discountRules;

        public DiscountCalculator(List<IDiscountRule> discountRules)
        {
            _discountRules = discountRules;
        }

        #region IDiscountCalculator Members

        public decimal Calculate(int itemCount)
        {
            return _discountRules
                .First(dr => dr.Match(itemCount))
                .Amount;
        }

        #endregion
    }
}
