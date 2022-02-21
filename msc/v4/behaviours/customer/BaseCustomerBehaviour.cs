using msc.v4.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v4.behaviours.customer
{
    
    // <summary> Class <c>BaseCustomerClass</c> models the scheleton of a Customer object.
    // <c>CustomerTypes</c> defines the possible types of customers in the system.
    // </summary
    public abstract class BaseCustomerBehaviour
    {
        // <c>_customer</c> holds a reference to the customer object that can be used to trigger a Behaviour Change
        protected Customer _customer;

        // <c>CustomerTypes</c> defines the possible types of customers in the system.
        public abstract CustomerTypes CustomerType
        {
            get;
        }


        public void SetCustomerContext(Customer customer)
        {
            this._customer = customer;
        }


        // <summary> Method <c>EvaluateDiscount</c> returns the price that a customer has to pay for .
        // <c>amount</c>     item real price   
        // <c>myDiscount</c> percentage of discount
        // </summary
        public abstract decimal EvaluateDiscount(decimal amount, decimal myDiscount);



    }
}
