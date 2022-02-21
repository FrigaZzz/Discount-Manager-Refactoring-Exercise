using msc.v4.model;
using msc.v4.behaviours.customer;

using System;
using msc.v4.managers;

namespace msc.v4
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountManager d = new DiscountManager();

            Customer c1 = new Customer("AA1122",new MostValuableCustomer(),new DateTime(2019,1,1));
            Customer c2 = new Customer("BA1122", new ValuableCustomer(), new DateTime(2018, 1, 1));
            Customer c3 = new Customer("CA1122", new RegisteredCustomer(), new DateTime(2017, 1, 1));
            Customer c4 = new Customer("DA1122", new UnregisteredCustomer(), new DateTime(2016, 1, 1));

            Item i = new Item(50);

            Console.WriteLine(d.CalculateDiscountedPrice(c1, i));
            Console.WriteLine(d.CalculateDiscountedPrice(c2, i));
            Console.WriteLine(d.CalculateDiscountedPrice(c3, i));
            Console.WriteLine(d.CalculateDiscountedPrice(c4, i));

        }
    }
}
