using msc.v8.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static msc.v8.constants.DiscountConstants;

namespace msc.v8.managers
{
   public interface IDiscountTypeStrategyFactory
   {
        public  ICustomerDiscountStrategy getDiscountStrategyInstance(CustomerType customerType);
   }
}
