using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v3.model
{

    public  class RegisteredCustomer:BaseCustomerClass
    {


        public RegisteredCustomer( DateTime registrationDate = new DateTime(), CustomerTypes customerType = CustomerTypes.mostValuable) :
            base(registrationDate, customerType)
        {
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));

        }

    }
}
