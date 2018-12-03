using CustomerManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Services
{
    public class RepositoryService : IRepositoryService
    {

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
                {
                    new Customer {Name = "John Smith", Gender = Gender.Male, DateOfBirth = new DateTime(1950, 15, 10)},
                    new Customer {Name = "Mary Smith", Gender = Gender.Female, DateOfBirth = new DateTime(1953, 15, 10)},
                    new Customer {Name = "Paul Brown", Gender = Gender.Male, DateOfBirth = new DateTime(1978, 15, 10)},
                    new Customer {Name = "Mary Brown", Gender = Gender.Female, DateOfBirth = new DateTime(1965, 15, 10)},
                    new Customer {Name = "Joe Super", Gender = Gender.Male, DateOfBirth = new DateTime(1980, 15, 10)},
                    new Customer {Name = "Helen Mix", Gender = Gender.Female, DateOfBirth = new DateTime(1985, 15, 10)}
                };

            return customers;
        }

    }
}
