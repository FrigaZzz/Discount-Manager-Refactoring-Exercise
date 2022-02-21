using msc.v8.constants;
using msc.v8.model;
using msc.v8.Repository.CustomerRepository;
using msc.v8.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static msc.v8.constants.DiscountConstants;

namespace msc.v8.managers
{
    public class DiscountManager
    {
        private readonly ICustomerRepository _customers;
        private readonly IDiscountTypeStrategyFactory _discountFactory; // selects the strategy based on the customer status
        private readonly ICustomerTypeDefinitorStrategy _evalStrategy; //  strategy to evaluate the customer status
        private readonly ISeniorityDiscountStrategyFactory _seniorityFactory; //  strategy to evaluate the customer dicount if senior

        public DiscountManager(IDiscountTypeStrategyFactory factory,
            ICustomerRepository customers, 
            ICustomerTypeDefinitorStrategy evalStrategy,
            ISeniorityDiscountStrategyFactory seniorityFactory
            )
        {
            _discountFactory = factory;
            _customers = customers;
            _evalStrategy = evalStrategy;
            _seniorityFactory = seniorityFactory;
        }


        public decimal ApplyDiscount(decimal price, Customer customer )
        {

            int customerAccountSeniorityYears = customer.RegistrationDate != null ? (DateTime.Now.Year -customer.RegistrationDate.Value.Year  ): 0;
            CustomerType customerType= _evalStrategy.EvaluateCustomer(customer);
            return ApplyDiscountInner(price, customerType, customerAccountSeniorityYears);
        }

        private decimal ApplyDiscountInner(decimal price, CustomerType customerType,
                                     int customerAccountSeniorityYears)
        {
          
            ICustomerDiscountStrategy discountTypeBehaviour = _discountFactory.getDiscountStrategyInstance(customerType);
            ISeniorityDiscountStrategy seniorityDiscountBehaviour = _seniorityFactory.getSeniorityDiscountStrategyInstance(customerType);

            decimal priceAfterDiscount = 0;

            priceAfterDiscount = discountTypeBehaviour.ApplyCustomerDiscount(price);
            priceAfterDiscount = seniorityDiscountBehaviour.CalculateCustomerSeniorityDiscount(customerAccountSeniorityYears, priceAfterDiscount);
            return priceAfterDiscount;
        }

        

    }
}
