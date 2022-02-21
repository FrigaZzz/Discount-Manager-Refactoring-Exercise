using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc
{
    
    public  class UnregisteredCustomer:BaseCustomerClass
    {


        public UnregisteredCustomer(int years) : base(years)
        {
            Type =CustomerTypes.unregistered;
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return amount;
        }

    }
}
