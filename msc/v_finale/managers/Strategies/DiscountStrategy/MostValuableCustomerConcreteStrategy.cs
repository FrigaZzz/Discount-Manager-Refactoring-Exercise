using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v8.constants;

namespace msc.v8.Strategies
{

    public  class MostValuableCustomerConcreteStrategy : ICustomerDiscountStrategy
    {

        public decimal ApplyCustomerDiscount(decimal price)
        {
            return price - (DiscountConstants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS * price);
        }
    }
}
