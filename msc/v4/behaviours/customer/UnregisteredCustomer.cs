using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v4.model;

namespace msc.v4.behaviours.customer
{

    public  class UnregisteredCustomer: BaseCustomerBehaviour
    {

        public override CustomerTypes CustomerType
        {
            get { return CustomerTypes.unregistered; }
        }



        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return amount;
        }

    }
}
