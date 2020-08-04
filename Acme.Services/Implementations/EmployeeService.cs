using System;
using System.Collections.Generic;
using System.Linq;
using Acme.DataAccess.Implementations;
using Acme.DataAccess.Interfaces;
using Acme.Models;

namespace Acme.Services.Implementations
{
    public class EmployeeService
    {
        protected IEmployeeRepository EmployeeRepository;
        
        public EmployeeService()
        {
            EmployeeRepository = new EmployeeRepository();
        }
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return EmployeeRepository.GetEmployees();
        }

        public IEnumerable<Employee> GetEmployees(string searchText)
        {
            return EmployeeRepository.GetEmployees(searchText);
        }

        public void SeedEmployeesData()
        {
            if (EmployeeRepository.GetEmployees().Any())
            {
                return;
            }

            EmployeeRepository.Add(CreateTestEmployee("Dave", "Smith"));
            EmployeeRepository.Add(CreateTestEmployee("Fred", "Brown"));
            EmployeeRepository.Add(CreateTestEmployee("Louise", "Pinnock"));
            EmployeeRepository.Add(CreateTestEmployee("Dave", "Ball"));
            EmployeeRepository.Add(CreateTestEmployee("Louise", "Greene"));
            EmployeeRepository.Add(CreateTestEmployee("Alan", "Pullman"));
            EmployeeRepository.Add(CreateTestEmployee("Brenda", "Storey"));
            EmployeeRepository.Add(CreateTestEmployee("Carol", "Soloman"));
            EmployeeRepository.Add(CreateTestEmployee("Dale", "Simpson"));
            EmployeeRepository.Add(CreateTestEmployee("Emma", "Smith"));
            EmployeeRepository.Add(CreateTestEmployee("Fiona", "Brown"));
            EmployeeRepository.Add(CreateTestEmployee("George", "Little"));
            EmployeeRepository.Add(CreateTestEmployee("Harry", "Smith"));
            EmployeeRepository.Add(CreateTestEmployee("Ian", "Wibble"));
            EmployeeRepository.Add(CreateTestEmployee("Kevin", "Brown"));
            EmployeeRepository.Add(CreateTestEmployee("Louise", "Lewis"));
            EmployeeRepository.Add(CreateTestEmployee("Martin", "Kelvin"));
            EmployeeRepository.Add(CreateTestEmployee("Nicola", "Homer"));
            EmployeeRepository.Add(CreateTestEmployee("Peter", "Simpson"));
            EmployeeRepository.Add(CreateTestEmployee("Rachel", "Smith"));
            EmployeeRepository.Add(CreateTestEmployee("Rose", "Brown"));
        }
        
        public void AddEmployee(Employee employee)
        {
            EmployeeRepository.Add(employee);
        }

        protected Employee CreateTestEmployee(string firstname, string surname)
        {
            var employee = new Employee
            {
                Firstname = firstname,
                Surname = surname,
                WorkEmail = $"{firstname.ToLower()}.{surname.ToLower()}@ert.com",
                PersonalEmail = $"{firstname.ToLower()}.{surname.ToLower()}@hotmail.com",
                StartDate = DateTime.Today,
                EnteredByUserId = 1
            };

            return employee;
        }
    }
}
