using msc.v8.model;
using msc.v8.Repository.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc.test
{ 
    public class CustomerMockRepository: ICustomerRepository
    {
        private List<Customer> _customers;

        public CustomerMockRepository(List<Customer> customers)
        {
            _customers = customers;
        }

        public Customer GetCustomer(string _guid)
        {
            foreach(Customer c in _customers)
            {
                if (c.Guid == _guid)
                    return c;
            }
            return null;
        }

    

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
