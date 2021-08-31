using System;
using System.Collections.Generic;

namespace Employee.Business
{
    public interface IEmployeeService
    {
        Models.Employee Create(string firstName, string lastName);
        IReadOnlyList<Models.Employee> GetAll();
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly List<Models.Employee> _employees = new List<Models.Employee>();

        public Models.Employee Create(string firstName, string lastName)
        {
            var newEmployee = new Models.Employee(Guid.NewGuid(), firstName, lastName);

            _employees.Add(newEmployee);

            return newEmployee;
        }

        public IReadOnlyList<Models.Employee> GetAll() => _employees;
    }
}
