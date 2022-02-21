using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v3.model
{

    public  class UnregisteredCustomer:BaseCustomerClass
    {


        public UnregisteredCustomer( DateTime registrationDate = new DateTime(), CustomerTypes customerType = CustomerTypes.unregistered) :
            base( registrationDate, customerType)
        {
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return amount;
        }

    }
}
