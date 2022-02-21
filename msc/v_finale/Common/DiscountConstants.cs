using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v8.constants
{
    public static class DiscountConstants
    {
        public const int MAXIMUM_DISCOUNT_FOR_SENIORITY = 5;
        public const decimal DISCOUNT_FOR_REGISTERED_CUSTOMERS = 0.1m;
        public const decimal DISCOUNT_FOR_VALUABLE_CUSTOMERS = 0.3m;
        public const decimal DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS = 0.5m;
        public enum CustomerType
        {
            Unregistered = 1,
            Registered = 2,
            ValuableCustomer = 3,
            MostValuableCustomer = 4
        }
    }
}
