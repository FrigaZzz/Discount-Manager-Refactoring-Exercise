using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msc.v8.model;

namespace msc.v8.Repository.CustomerRepository
{
    public interface ICustomerRepository
    {
        public Customer GetCustomer(string _guid);

        public List<Customer> GetCustomers();

    }
}
