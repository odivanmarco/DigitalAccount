using Domain.Contracts.Repositories.AddCustomer;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Repositories.AddCustomer
{
    public class AddCustomerRepository : IAddCustomerRepository
    {
        private readonly IList<Customer> _customer = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            _customer.Add(customer);
        }
    }
}
