using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v8.constants;

namespace msc.v8.Strategies
{

    public  class DefaultSeniorityDiscountStrategy : ISeniorityDiscountStrategy
    {
        public decimal CalculateCustomerSeniorityDiscount(int customerAccountSeniorityYears, decimal price)
        {
            decimal discountForLoyaltyInPercentage = (decimal)Math.Min(customerAccountSeniorityYears, DiscountConstants.MAXIMUM_DISCOUNT_FOR_SENIORITY) / 100;
            return price-(discountForLoyaltyInPercentage * price);
        }
    }
}
