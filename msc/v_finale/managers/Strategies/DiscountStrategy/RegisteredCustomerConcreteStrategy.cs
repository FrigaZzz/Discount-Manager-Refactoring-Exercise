using msc.v8.constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v8.Strategies
{

    public class RegisteredCustomerConcreteStrategy : ICustomerDiscountStrategy
    {
        public decimal ApplyCustomerDiscount(decimal price)
        {
            return price - (DiscountConstants.DISCOUNT_FOR_REGISTERED_CUSTOMERS * price);
        }
       
    }
}
