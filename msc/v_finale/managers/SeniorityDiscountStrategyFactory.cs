using msc.v8.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static msc.v8.constants.DiscountConstants;

namespace msc.v8.managers
{
   public class SeniorityDiscountStrategyFactory : ISeniorityDiscountStrategyFactory
    {
        public ISeniorityDiscountStrategy getSeniorityDiscountStrategyInstance(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Unregistered:
                    return new UnregisteredCustomerSeniorityDiscountStrategy();
                default:
                    return new DefaultSeniorityDiscountStrategy();

            }
            // defualt
            throw new NotImplementedException();
        }

   
    }
}
