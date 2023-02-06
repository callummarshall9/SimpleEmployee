using FluentAssertions;
using InterviewTest.Model;
using Moq;
using System.Linq;
using Xunit;

namespace InterviewTest.Services.Tests
{
    public partial class EmployeeServiceTests
    {
        [Fact]
        public void ShouldGetEmployees()
        {
            //given
            IQueryable<Employee> expectedEmployees = RandomEmployees()
                .AsQueryable();

            storageBrokerMock.Setup(storageBrokerMock =>
                storageBrokerMock.GetAllEmployees())
                .Returns(expectedEmployees);

            //when
            IQueryable<Employee> actualEmployees = employeeService.GetAllEmployees();

            //then
            actualEmployees.Should().BeEquivalentTo(expectedEmployees);

            storageBrokerMock.Verify(storageBrokerMock =>
                storageBrokerMock.GetAllEmployees(),
                Times.Once());

            storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
