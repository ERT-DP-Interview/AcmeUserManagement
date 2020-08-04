using System.Collections.Generic;
using System.Linq;
using Acme.DataAccess.Interfaces;
using Acme.Models;
using System.Data.Entity;

namespace Acme.DataAccess.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (var context = new AcmeDbContext())
            {
                return context.Employees.Include(e => e.EnteredByUser).ToList();
            }
        }

        public IEnumerable<Employee> GetEmployees(string searchText)
        {
            using (var context = new AcmeDbContext())
            {
                var results = context.Employees
                    .Where(e => e.Firstname.Contains(searchText) || e.Surname.Contains(searchText) || e.WorkEmail.Contains(searchText) || e.PersonalEmail.Contains(searchText))
                    .ToList();

                foreach (var user in results)
                {
                    user.EnteredByUser = context.ApplicationUsers.FirstOrDefault(u => u.Id == user.EnteredByUserId);
                }

                return results;
            }
        }

        public void Add(Employee employee)
        {
            using (var context = new AcmeDbContext())
            {
                context.Employees.Add(employee);

                context.SaveChanges();
            }
        }
    }
}
