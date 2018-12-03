using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystem.Models;

namespace CustomerManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly IRepositoryService _repo;
        public CustomerService(IRepositoryService repo)
        {
            _repo = repo;
        }

        public double CalculateAverageAge()
        {
            if (_repo == null) throw new ArgumentNullException();

            var custAge = _repo.GetCustomers().Average(c => CalculateCustomerAge(c.DateOfBirth));

            return custAge;
        }

        private int CalculateCustomerAge(DateTime dateOfBirth)
        {
            return DateTime.Now.Year - dateOfBirth.Year; 
        }

        public double CalculateAverageAge(Gender gender)
        {
            var custAge = _repo.GetCustomers()
                .Where(c => c.Gender == gender)
                .Average(c => CalculateCustomerAge(c.DateOfBirth)); 
            return custAge;
        }


    }
}
