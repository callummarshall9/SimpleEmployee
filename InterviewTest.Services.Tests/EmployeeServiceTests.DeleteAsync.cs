using InterviewTest.Model;
using Moq;
using Xunit;

namespace InterviewTest.Services.Tests
{
    public partial class EmployeeServiceTests
    {
        [Fact]
        public async void ShouldDeleteEmployeeAsync()
        {
            //given
            Employee inputEmployee = RandomEmployee();

            //when
            await employeeService.DeleteEmployeeAsync(inputEmployee);

            //then
            storageBrokerMock.Verify(storageBrokerMock =>
                storageBrokerMock.DeleteEmployeeAsync(inputEmployee),
                Times.Once());

            storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
