using FluentAssertions;
using Force.DeepCloner;
using InterviewTest.Model;
using Moq;
using Xunit;

namespace InterviewTest.Services.Tests
{
    public partial class EmployeeServiceTests
    {
        [Fact]
        public async void ShouldAddEmployeeAsync()
        {
            //given
            Employee inputEmployee = RandomEmployee();
            Employee expectedEmployee = inputEmployee.DeepClone();

            storageBrokerMock.Setup(storageBrokerMock =>
                storageBrokerMock.AddEmployeeAsync(inputEmployee))
                .ReturnsAsync(expectedEmployee);

            //when
            Employee actualEmployee = await employeeService.AddEmployeeAsync(inputEmployee);

            //then
            actualEmployee.Should().BeEquivalentTo(expectedEmployee);

            storageBrokerMock.Verify(storageBrokerMock =>
                storageBrokerMock.AddEmployeeAsync(inputEmployee),
                Times.Once());

            storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
