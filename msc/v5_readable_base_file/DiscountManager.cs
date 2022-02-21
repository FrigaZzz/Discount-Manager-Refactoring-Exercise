using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Starting from v0:
/// - added human readable variables names
/// </summary>
namespace msc.v5
{
    public class DiscountManager
    {
        public enum CustomerType
        {
            Unregistered = 1,
            Registered = 2,
            ValuableCustomer = 3,
            MostValuableCustomer = 4
        }


        public decimal ApplyCustomerDiscount(decimal price, CustomerType customerType,
                                     int customerAccountSeniorityYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForSeniorityPercentage = (customerAccountSeniorityYears > 5) ?
                    (decimal)5 / 100 : (decimal)customerAccountSeniorityYears / 100;

            if (customerType == CustomerType.Unregistered)
            {
                priceAfterDiscount = price;
            }
            else if (customerType == CustomerType.Registered)
            {
                priceAfterDiscount = (price - (0.1m * price)) -
                     (discountForSeniorityPercentage * (price - (0.1m * price)));
            }
            else if (customerType == CustomerType.ValuableCustomer)
            {
                priceAfterDiscount = (0.7m * price) -
                     (discountForSeniorityPercentage * (0.7m * price));
            }
            else if (customerType == CustomerType.MostValuableCustomer)
            {
                priceAfterDiscount = (price - (0.5m * price)) -
                     (discountForSeniorityPercentage * (price - (0.5m * price)));
            }
            return priceAfterDiscount;
        }
    }
}
