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
        public async void ShouldUpdateEmployeeAsync()
        {
            //given
            Employee inputEmployee = RandomEmployee();
            Employee expectedEmployee = inputEmployee.DeepClone();

            storageBrokerMock.Setup(storageBrokerMock =>
                storageBrokerMock.UpdateEmployeeAsync(inputEmployee))
                .ReturnsAsync(expectedEmployee);

            //when
            Employee actualEmployee = await employeeService.UpdateEmployeeAsync(inputEmployee);

            //then
            actualEmployee.Should().BeEquivalentTo(expectedEmployee);

            storageBrokerMock.Verify(storageBrokerMock =>
                storageBrokerMock.UpdateEmployeeAsync(inputEmployee),
                Times.Once());

            storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
