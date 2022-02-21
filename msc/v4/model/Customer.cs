using msc.v4.behaviours.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v4.model
{
    public enum CustomerTypes
    {
        unregistered = 1, registered = 2, valuable = 3, mostValuable = 4
    }
    public class Customer
    {
        private readonly String _guid;
        private readonly DateTime _registrationDate;
        private   BaseCustomerBehaviour _behaviours;

        public Customer(string guid,BaseCustomerBehaviour behaviours, DateTime registrationDate = new DateTime())
        {
            _guid = guid;
            _registrationDate = registrationDate;
            _behaviours = behaviours;
        }

        // State pattern change
        public void SetBehave(BaseCustomerBehaviour behaviours)
        {
            _behaviours = behaviours;
        }

        public DateTime RegistrationDate
        {
            get { return _registrationDate; }

        }

        // <summary> Method <c>EvaluateDiscount</c> returns the price that a customer has to pay for .
        // <c>CustomerTypes</c> defines the possible types of customers in the system.
        // <c>amount</c>     item real price   
        // <c>myDiscount</c> percentage of discount
        // </summary
        public decimal EvaluateDiscount(decimal amount, decimal myDiscount)
        {
            return _behaviours.EvaluateDiscount(amount, myDiscount);
        }


    }
}
