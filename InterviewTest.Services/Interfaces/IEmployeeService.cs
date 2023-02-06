using InterviewTest.Model;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Services.Interfaces
{
    public interface IEmployeeService
    {
        ValueTask<Employee> DeleteEmployeeAsync(Employee employee);
        IQueryable<Employee> GetAllEmployees();
        ValueTask<Employee> AddEmployeeAsync(Employee employee);
        ValueTask<Employee> UpdateEmployeeAsync(Employee employee);
    }
}
