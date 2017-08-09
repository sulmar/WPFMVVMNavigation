using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMNavigation.Models;

namespace WPFMVVMNavigation.Services
{
    public class MockCustomersService : ICustomersService
    {
        

        public IList<Customer> Get()
        {
            var customers = new List<Customer>
            {
                new Customer { CustomerId = 1, FirstName = "Marcin" },
                new Customer { CustomerId = 1, FirstName = "Kasia" },
                new Customer { CustomerId = 1, FirstName = "Bartek" },
            };

            return customers;
        }
    }
}
