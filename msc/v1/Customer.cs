using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v1
{
    public enum CustomerTypes
    {
      unregistered, registered, valuable, mostValuable
    }
    public  class Customer
    {

        private readonly int _type;
        private readonly int _years;

        public Customer(int type, int years)
        {
            _type = type;
            _years = years;

        }
        public int Type
        {
            get { return _type; }
        }

        public int Years
        {
            get { return _years; }
        }



    }
}
