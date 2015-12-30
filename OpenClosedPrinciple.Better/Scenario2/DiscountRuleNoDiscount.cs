using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario2
{
    public class DiscountRuleNoDiscount : IDiscountRule
    {
        #region IDiscountRule Members

        public decimal Amount
        {
            get { return 0; }
        }

        public bool Match(int itemCount)
        {
            return itemCount < 3;
        }

        #endregion
    }
}
