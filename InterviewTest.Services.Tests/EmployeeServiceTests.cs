using InterviewTest.Data.Interfaces;
using InterviewTest.Model;
using InterviewTest.Services.Interfaces;
using Moq;
using System;
using System.Linq;
using Tynamix.ObjectFiller;

namespace InterviewTest.Services.Tests
{
    public partial class EmployeeServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IEmployeeService employeeService;

        public EmployeeServiceTests()
        {
            storageBrokerMock = new Mock<IStorageBroker>();
            employeeService = new EmployeeService(storageBrokerMock.Object);
        }

        public Employee[] RandomEmployees()
            => Enumerable.Range(0, new Random().Next(1, 10))
                .Select(_ => RandomEmployee())
                .ToArray();

        public Employee RandomEmployee()
            => GetEmployeeFiller().Create();

        public Filler<Employee> GetEmployeeFiller()
            => new Filler<Employee>();
    }
}
