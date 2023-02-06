using InterviewTest.Data.Interfaces;
using InterviewTest.Model;
using InterviewTest.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IStorageBroker storageBroker;

        public EmployeeService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public ValueTask DeleteEmployeeAsync(Employee employee)
            => storageBroker.DeleteEmployeeAsync(employee);

        public IQueryable<Employee> GetAllEmployees()
            => storageBroker.GetAllEmployees();

        public ValueTask<Employee> AddEmployeeAsync(Employee employee)
            => storageBroker.AddEmployeeAsync(employee);

        public ValueTask<Employee> UpdateEmployeeAsync(Employee employee)
            => storageBroker.UpdateEmployeeAsync(employee);
    }
}