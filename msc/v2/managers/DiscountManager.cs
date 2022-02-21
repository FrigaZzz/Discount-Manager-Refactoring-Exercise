/*
 * Discount Manager: Calculate a discount from a 
 * customer type (unregistered, registered, valuable, most valuable) 
 * and a time of having an account in years
 */

namespace msc.v2
{ 
    public class DiscountManager
    {

        public decimal Calculate(BaseCustomerClass c, decimal amount)
        {
            decimal disc = (c.Years > 5) ? (decimal)5 / 100 : (decimal)c.Years / 100;
            return c.EvaluateDiscount(amount, disc);
        }

    }

}









