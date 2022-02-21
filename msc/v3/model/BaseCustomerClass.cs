using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v3.model
{
    public enum CustomerTypes
    {
      unregistered = 1, registered =2, valuable = 3, mostValuable=4
    }
    // <summary> Class <c>BaseCustomerClass</c> models the scheleton of a Customer object.
    // <c>CustomerTypes</c> defines the possible types of customers in the system.
    // </summary
    public abstract class  BaseCustomerClass
    {
        private readonly CustomerTypes _customerType;
        private readonly DateTime _registrationDate;

        public BaseCustomerClass(
            DateTime registrationDate =new  DateTime(), 
            CustomerTypes customerType = CustomerTypes.unregistered   )
        {
            _registrationDate = registrationDate;
            _customerType = customerType;
        }

   
        public CustomerTypes Type
        {
            get { return _customerType; }
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
        public abstract decimal EvaluateDiscount(decimal amount, decimal myDiscount);

    }
}
