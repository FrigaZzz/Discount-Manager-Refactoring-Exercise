using msc.v3;
using msc.v3.managers;
using msc.v3.model;
using System;

namespace msc.v3
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountManager d = new DiscountManager();
            MostValuableCustomer m1 = new MostValuableCustomer(new DateTime(2019, 1, 1));
            ValuableCustomer m2 = new ValuableCustomer(new DateTime(2019, 1, 1));
            RegisteredCustomer m3 = new RegisteredCustomer(new DateTime(2019, 1, 1));
            UnregisteredCustomer m4 = new UnregisteredCustomer(new DateTime(2019, 1, 1));


            Item i = new Item(50);

            Console.WriteLine(d.CalculateDiscountedPrice(m1, i));
            Console.WriteLine(d.CalculateDiscountedPrice(m2, i));
            Console.WriteLine(d.CalculateDiscountedPrice(m3, i));
            Console.WriteLine(d.CalculateDiscountedPrice(m4, i));
        }
    }
}
