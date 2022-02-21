using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc
{
    public enum CustomerTypes
    {
      unregistered = 1, registered =2, valuable = 3, mostValuable=4
    }
    public abstract class  BaseCustomerClass
    {

        private CustomerTypes _type;
        private  int _years;

        public BaseCustomerClass(int years)
        {
            _years = years;
        }

        public CustomerTypes Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Years
        {
            get { return _years; }
            set { _years = value; }

        }


        public abstract decimal EvaluateDiscount(decimal amount, decimal disc);

    }
}
