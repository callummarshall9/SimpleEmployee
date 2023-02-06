﻿using InterviewTest.Data;
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

        public ValueTask<Employee> DeleteEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Employee> AddEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Employee> UpdateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}