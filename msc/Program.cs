using msc.v1;
using System;

namespace msc
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountManager d = new DiscountManager();
            MostValuableCustomer m = new MostValuableCustomer(4);
            ValuableCustomer m2 = new ValuableCustomer(3);
            RegisteredCustomer m3 = new RegisteredCustomer(2);
            UnregisteredCustomer m4 = new UnregisteredCustomer(7);

            Console.WriteLine(d.Calculate(m, 50));
            Console.WriteLine(d.Calculate(m2, 50));
            Console.WriteLine(d.Calculate(m3, 50));
            Console.WriteLine(d.Calculate(m4, 50));


            MyDiscountManager d2 = new MyDiscountManager();
            Customer  t = new Customer(4,4);

            Console.WriteLine(d2.Calculate(t, 50));
        }
    }
}
