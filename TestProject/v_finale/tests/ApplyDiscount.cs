using System;
using Xunit;
using msc.v8.managers;
using msc.v8.Repository.CustomerRepository;
using msc.test;
using msc.v8.model;
using msc.v8.Strategies;
using msc.v0;
using System.Collections.Generic;
using static msc.v8.constants.DiscountConstants;

namespace TestProject
{
    public class ApplyDiscount
    {
        [Fact]
        public void ApplyDiscount_unregistered_customer()
        {
            //Arrange
            decimal price  = 50;
            CustomerType customerType = CustomerType.Unregistered;
            int customerAccountSeniorityYears = 5;

            Customer customer = new Customer(TestConstants.UNREGISTERED,DateTime.Now.AddYears(customerAccountSeniorityYears*-1));

            List<Customer>  customers = new List<Customer>();
            ICustomerRepository repo= new CustomerMockRepository(customers);
            IDiscountTypeStrategyFactory typeFact= new DiscountTypeStrategyFactory();
            ISeniorityDiscountStrategyFactory senFact = new SeniorityDiscountStrategyFactory();

            ISeniorityDiscountStrategy seniorStrat = new DefaultSeniorityDiscountStrategy();
            ICustomerTypeDefinitorStrategy evalState = new CustomerTypeDefinitorMockupStrategy();
            DiscountManager manager_refactored= new DiscountManager(typeFact, repo, evalState, senFact);
            Class1 manager_not_refactored = new();



            //Act
            decimal postRefactor = manager_refactored.ApplyDiscount(price, customer);
            decimal preRefactor = manager_not_refactored.Calculate(price, (int)customerType, customerAccountSeniorityYears);

            //Assert
            Assert.True(postRefactor == preRefactor, $"The method ApplyDiscount is not working properly: {postRefactor} {preRefactor} ");

        }

        [Fact]
        public void ApplyDiscount_registered_customer()
        {
            //Arrange
            decimal price = 50;
            CustomerType customerType = CustomerType.Registered;
            int customerAccountSeniorityYears = 5;

            Customer customer = new Customer(TestConstants.REGISTERED, DateTime.Now.AddYears(customerAccountSeniorityYears * -1));

            List<Customer> customers = new List<Customer>();
            ICustomerRepository repo = new CustomerMockRepository(customers);
            IDiscountTypeStrategyFactory typeFact = new DiscountTypeStrategyFactory();
            ISeniorityDiscountStrategyFactory senFact = new SeniorityDiscountStrategyFactory();

            ISeniorityDiscountStrategy seniorStrat = new DefaultSeniorityDiscountStrategy();
            ICustomerTypeDefinitorStrategy evalState = new CustomerTypeDefinitorMockupStrategy();
            DiscountManager manager_refactored = new DiscountManager(typeFact, repo, evalState, senFact);
            Class1 manager_not_refactored = new();



            //Act
            decimal postRefactor = manager_refactored.ApplyDiscount(price, customer);
            decimal preRefactor = manager_not_refactored.Calculate(price, (int)customerType, customerAccountSeniorityYears);

            //Assert
            Assert.True(postRefactor == preRefactor, $"The method ApplyDiscount is not working properly: {postRefactor} {preRefactor} ");

        }

        [Fact]
        public void ApplyDiscount_valuable_customer()
        {
            //Arrange
            decimal price = 50;
            CustomerType customerType = CustomerType.ValuableCustomer;
            int customerAccountSeniorityYears = 5;

            Customer customer = new Customer(TestConstants.VALUABLE, DateTime.Now.AddYears(customerAccountSeniorityYears * -1));

            List<Customer> customers = new List<Customer>();
            ICustomerRepository repo = new CustomerMockRepository(customers);
            IDiscountTypeStrategyFactory typeFact = new DiscountTypeStrategyFactory();
            ISeniorityDiscountStrategyFactory senFact = new SeniorityDiscountStrategyFactory();

            ISeniorityDiscountStrategy seniorStrat = new DefaultSeniorityDiscountStrategy();
            ICustomerTypeDefinitorStrategy evalState = new CustomerTypeDefinitorMockupStrategy();
            DiscountManager manager_refactored = new DiscountManager(typeFact, repo, evalState, senFact);
            Class1 manager_not_refactored = new();



            //Act
            decimal postRefactor = manager_refactored.ApplyDiscount(price, customer);
            decimal preRefactor = manager_not_refactored.Calculate(price, (int)customerType, customerAccountSeniorityYears);

            //Assert
            Assert.True(postRefactor == preRefactor, $"The method ApplyDiscount is not working properly: {postRefactor} {preRefactor} ");

        }

        [Fact]
        public void ApplyDiscount_most_valuable_customer()
        {
            //Arrange
            decimal price = 50;
            CustomerType customerType = CustomerType.MostValuableCustomer;
            int customerAccountSeniorityYears = 5;

            Customer customer = new Customer(TestConstants.MOSTVALUABLE, DateTime.Now.AddYears(customerAccountSeniorityYears * -1));

            List<Customer> customers = new List<Customer>();
            ICustomerRepository repo = new CustomerMockRepository(customers);
            IDiscountTypeStrategyFactory typeFact = new DiscountTypeStrategyFactory();
            ISeniorityDiscountStrategyFactory senFact = new SeniorityDiscountStrategyFactory();

            ISeniorityDiscountStrategy seniorStrat = new DefaultSeniorityDiscountStrategy();
            ICustomerTypeDefinitorStrategy evalState = new CustomerTypeDefinitorMockupStrategy();
            DiscountManager manager_refactored = new DiscountManager(typeFact, repo, evalState, senFact);
            Class1 manager_not_refactored = new();



            //Act
            decimal postRefactor = manager_refactored.ApplyDiscount(price, customer);
            decimal preRefactor = manager_not_refactored.Calculate(price, (int)customerType, customerAccountSeniorityYears);

            //Assert
            Assert.True(postRefactor == preRefactor, $"The method ApplyDiscount is not working properly: {postRefactor} {preRefactor} ");

        }
    }
}
