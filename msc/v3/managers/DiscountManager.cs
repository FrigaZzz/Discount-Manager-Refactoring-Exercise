/*
 * Discount Manager: Calculate a discount from a 
 * customer type (unregistered, registered, valuable, most valuable) 
 * and a time of having an account in years
 */

using msc.v3.model;
using System;

namespace msc.v3.managers
{ 
    public class DiscountManager
    {

        // <summary> Method <c>CalculateDiscountedPrice</c> returns the price that a customer has to pay for .
        // <c>customer</c> customer
        // <c>item</c>     item real price   
        // </summary
        public decimal CalculateDiscountedPrice(BaseCustomerClass customer, Item item)
       {
            int customerSeniority = customer.RegistrationDate.Year - DateTime.Now.Year;
            decimal disc = (decimal) Math.Max(customerSeniority, 5) / 10;
            return customer.EvaluateDiscount(item.Price,disc);
       }

    }
}










