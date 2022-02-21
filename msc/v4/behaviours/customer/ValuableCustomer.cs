using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v4.model;

namespace msc.v4.behaviours.customer
{

    public  class ValuableCustomer : BaseCustomerBehaviour
    {


        public override CustomerTypes CustomerType
        {
            get { return CustomerTypes.valuable; }
        }



        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            return  (0.7m * amount) - disc * (0.7m * amount);

        }
    }
}
