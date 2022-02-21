using msc.v4.behaviours.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v8.model
{
 
    public class Customer
    {
        private readonly String _guid;
        private readonly DateTime? _registrationDate;

        public Customer(string guid, DateTime? registrationDate)
        {
            _guid = guid;
            _registrationDate = registrationDate;
        }

        public DateTime? RegistrationDate
        {
            get { return _registrationDate; }

        }

        public String Guid
        {
            get { return _guid; }

        }


    }
}
