using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v3.model
{

    public  class ValuableCustomer : BaseCustomerClass
    {


        public ValuableCustomer(DateTime registrationDate = new DateTime(), CustomerTypes customerType = CustomerTypes.valuable) :
            base(registrationDate, customerType)
        {
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return  (0.7m * amount) - disc * (0.7m * amount);

        }
    }
}
