using msc.v4.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v4.behaviours.customer
{

    public  class MostValuableCustomer : BaseCustomerBehaviour
    {
        public override CustomerTypes CustomerType
        {
            get { return CustomerTypes.mostValuable;  }
        }

        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            var result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            return result;
        }

    }
}
