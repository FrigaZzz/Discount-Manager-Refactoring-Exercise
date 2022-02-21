using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Starting from v5:
/// - generalized the discount evaluation 
/// - switch instead of if-then-else
/// - added Constant file containing 
/// </summary>
namespace msc.v6_fix_discount_calculation
{
    public class DiscountManager
    {
        public enum CustomerType
        {
            NotRegistered = 1,
            Registered = 2,
            ValuableCustomer = 3,
            MostValuableCustomer = 4
        }

        public decimal ApplyCustomerDiscount(decimal price, CustomerType customerType,
                                     int customerAccountSeniorityYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForSeniorityPercentage = (customerAccountSeniorityYears > Constants.MAXIMUM_DISCOUNT_FOR_SENIORITY) ?
                    (decimal)Constants.MAXIMUM_DISCOUNT_FOR_SENIORITY / 100 : (decimal)customerAccountSeniorityYears / 100;

            switch (customerType)
            {
                case CustomerType.NotRegistered:
                    priceAfterDiscount = price;
                    break;
                case CustomerType.Registered:
                    priceAfterDiscount = (price - (Constants.DISCOUNT_FOR_REGISTERED_CUSTOMERS * price));
                    priceAfterDiscount -= (discountForSeniorityPercentage * priceAfterDiscount);
                 
                    break;

                case CustomerType.ValuableCustomer:
                    priceAfterDiscount = (price - (Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS * price));
                    priceAfterDiscount -= (discountForSeniorityPercentage * priceAfterDiscount);
                    break;

                case CustomerType.MostValuableCustomer:
                    priceAfterDiscount = (price - (Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS * price));
                    priceAfterDiscount -= (discountForSeniorityPercentage * priceAfterDiscount);
                    break;
                default:
                    priceAfterDiscount = price;
                    break;
            }
            return priceAfterDiscount;
        }
    }
}
