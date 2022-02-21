using msc.v8.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static msc.v8.constants.DiscountConstants;

namespace msc.v8.managers
{
   public class DiscountTypeStrategyFactory: IDiscountTypeStrategyFactory
    {
        public  ICustomerDiscountStrategy getDiscountStrategyInstance(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.MostValuableCustomer:
                    return new MostValuableCustomerConcreteStrategy();
                case CustomerType.ValuableCustomer:
                    return new ValuableCustomerConcreteStrategy();
                case CustomerType.Registered:
                    return new RegisteredCustomerConcreteStrategy();
                case CustomerType.Unregistered:
                    return new UnregisteredCustomerConcreteStrategy();
            }
            // defualt
            throw new NotImplementedException();
        }
   }
}
