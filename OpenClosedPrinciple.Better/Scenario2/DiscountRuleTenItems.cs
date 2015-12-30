using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario2
{
    public class DiscountRuleTenItems : IDiscountRule
    {
        #region IDiscountRule Members

        public decimal Amount
        {
            get { return 15; }
        }

        public bool Match(int itemCount)
        {
            return itemCount >= 10 && itemCount < 15;
        }

        #endregion
    }
}
