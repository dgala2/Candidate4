using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CustomerManagementSystem.Services;


namespace CustomerManagementSystemTests
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IRepositoryService> _repo;
        private CustomerService _systemunderTest;

        [TestInitialize]
        public void Setup()
        {
            _repo = new Mock<IRepositoryService>();
            _systemunderTest = new CustomerService(_repo.Object);
        }

        [TestMethod]
        [ExpectedException(ArgumentNullException)]
        public void CalculateAverageAge_ReturnsEmptyList()
        {
            _repo.Setup(r = r.GetCustomers()).Returns(It.IsAny<List<Customer>>());

            var res = _systemunderTest.CalculateAverageAge();



        }
    }
}
