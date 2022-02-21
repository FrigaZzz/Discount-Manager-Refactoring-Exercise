using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v3.model
{
    
    public  class MostValuableCustomer : BaseCustomerClass
    {


        public MostValuableCustomer(DateTime registrationDate = new DateTime(),
            CustomerTypes customerType = CustomerTypes.mostValuable ):
            base(registrationDate,customerType)
        {

        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            var result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            return result;
        }
    }
}
