using msc.v8.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.v8.Repository.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(string _guid)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
