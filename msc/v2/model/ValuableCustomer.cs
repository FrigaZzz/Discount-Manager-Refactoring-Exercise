using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc
{
    
    public  class ValuableCustomer : BaseCustomerClass
    {


        public ValuableCustomer(int years) : base(years)
        {
            Type =CustomerTypes.valuable;
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return  (0.7m * amount) - disc * (0.7m * amount);

        }
    }
}
