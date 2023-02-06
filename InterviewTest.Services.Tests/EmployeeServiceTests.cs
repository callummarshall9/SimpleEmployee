using InterviewTest.Data.Interfaces;
using InterviewTest.Model;
using InterviewTest.Services.Interfaces;
using Moq;
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

        public Employee RandomEmployee()
            => GetEmployeeFiller().Create();

        public Filler<Employee> GetEmployeeFiller()
            => new Filler<Employee>();
    }
}
