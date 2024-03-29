﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v2
{

    public  class MostValuableCustomer : BaseCustomerClass
    {


        public MostValuableCustomer(int years) : base(years)
        {
            Type =CustomerTypes.mostValuable;
        }
     


        public override decimal EvaluateDiscount(decimal amount, decimal disc)
        {
            var result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            return result;
        }
    }
}
