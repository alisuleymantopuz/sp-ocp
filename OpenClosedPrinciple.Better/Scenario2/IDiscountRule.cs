using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Better.Scenario2
{
    public interface IDiscountRule
    {
        decimal Amount { get;}
        bool Match(int itemCount);
    }
}
