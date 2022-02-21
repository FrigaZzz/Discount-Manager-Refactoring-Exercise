using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v8.constants;
using msc.v8.model;
using msc.v8.Strategies;
using static msc.v8.constants.DiscountConstants;

namespace msc.test
{

    public class CustomerTypeDefinitorMockupStrategy : ICustomerTypeDefinitorStrategy
    {
        public CustomerType EvaluateCustomer(Customer customer)
        {
            switch (customer.Guid)
            {
                case TestConstants.MOSTVALUABLE:
                    return DiscountConstants.CustomerType.MostValuableCustomer;
                case TestConstants.VALUABLE:
                    return DiscountConstants.CustomerType.ValuableCustomer;
                case TestConstants.REGISTERED:
                    return DiscountConstants.CustomerType.Registered;
                case TestConstants.UNREGISTERED:
                    return DiscountConstants.CustomerType.Unregistered;
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
