using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v8.constants;

namespace msc.v8.Strategies
{

    public  class UnregisteredCustomerSeniorityDiscountStrategy : ISeniorityDiscountStrategy
    {
        public decimal CalculateCustomerSeniorityDiscount(int customerAccountSeniorityYears, decimal price)
        {
            return price;
        }
    }
}
