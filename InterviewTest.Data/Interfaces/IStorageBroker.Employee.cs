using InterviewTest.Model;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Data.Interfaces
{
    public interface IStorageBroker
    {
        ValueTask<Employee> DeleteEmployeeAsync(Employee employee);
        IQueryable<Employee> GetAllEmployees();
        ValueTask<Employee> InsertStudentAsync(Employee employee);
        ValueTask<Employee> UpdateEmployeeAsync(Employee employee);
        void Migrate();
    }
}