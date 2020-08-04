using System.Collections.Generic;
using Acme.Models;

namespace Acme.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        IEnumerable<Employee> GetEmployees(string searchText);

        void Add(Employee employee);
    }
}