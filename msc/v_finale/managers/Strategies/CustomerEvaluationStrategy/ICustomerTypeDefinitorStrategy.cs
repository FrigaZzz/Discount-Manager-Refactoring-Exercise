using msc.v8.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static msc.v8.constants.DiscountConstants;

namespace msc.v8.Strategies
{
    public interface ICustomerTypeDefinitorStrategy
    {
         public CustomerType EvaluateCustomer(Customer customer);
    }
}
