/*
 * Discount Manager: Calculate a discount from a 
 * customer type (unregistered, registered, valuable, most valuable) 
 * and a time of having an account in years
 */

using msc.v1;

public class MyDiscountManager
{

   public decimal Calculate(Customer c, decimal amount)
  {
    decimal result = 0;
    decimal disc = (c.Years > 5) ? (decimal)5/100 : (decimal)c.Years / 100; 
    if (c.Type == 1)
    {
      result = amount;
    }
    else if (c.Type == 2)
    {
      result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
    }
    else if (c.Type== 3)
    {
      result = (0.7m * amount) - disc * (0.7m * amount);
    }
    else if (c.Type == 4)
    {
      result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
    }
    return result;
  }
}










