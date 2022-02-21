using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc
{
    
    public  class RegisteredCustomer:BaseCustomerClass
    {


        public RegisteredCustomer(int years) : base(years)
        {
            Type =CustomerTypes.registered;
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));

        }

    }
}
