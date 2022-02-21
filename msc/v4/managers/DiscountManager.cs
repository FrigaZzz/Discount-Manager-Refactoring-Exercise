/*
 * Discount Manager: Calculate a discount from a 
 * customer type (unregistered, registered, valuable, most valuable) 
 * and a time of having an account in years
 */

using msc.v4.model;
using System;

namespace msc.v4.managers
{ 
    public class DiscountManager:BaseManager
    {

        // <summary> Method <c>CalculateDiscountedPrice</c> returns the price that a customer has to pay for .
        // <c>CustomerTypes</c> defines the possible types of customers in the system.
        // <c>amount</c>     item real price   
        // <c>myDiscount</c> percentage of discount
        // </summary
        public decimal CalculateDiscountedPrice(Customer customer, Item item)
        {
            int customerSeniority = customer.RegistrationDate.Year - DateTime.Now.Year;
            decimal disc = (decimal) Math.Max(customerSeniority, 5) / 10;
            return customer.EvaluateDiscount(item.Price,disc);
        }

    }
}










