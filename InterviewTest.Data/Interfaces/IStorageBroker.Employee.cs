using InterviewTest.Model;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Data.Interfaces
{
    public interface IStorageBroker
    {
        ValueTask DeleteEmployeeAsync(Employee employee);
        IQueryable<Employee> GetAllEmployees();
        ValueTask<Employee> AddEmployeeAsync(Employee employee);
        ValueTask<Employee> UpdateEmployeeAsync(Employee employee);
        void Migrate();
    }
}