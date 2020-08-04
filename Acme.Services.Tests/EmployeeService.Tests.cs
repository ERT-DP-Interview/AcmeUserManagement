using System;
using System.Collections.Generic;
using System.Linq;
using Acme.DataAccess.Interfaces;
using Acme.Models;
using Acme.Services.Implementations;
using FakeItEasy;
using NUnit.Framework;

namespace Acme.Services.Tests
{
    [TestFixture]
    public class EmployeeServiecServiceTests
    {
        [Test]
        public void WhenTheGetEmployeesStringOverloadIsCalledAndTheEmployeeRepositoryGetEmployeesMethodReturnsNoResultsThenNoResultsAreReturned()
        {
            var fakeEmployeeRepositoryRepository = A.Fake<IEmployeeRepository>();

            var employeeService = new EmployeeService(fakeEmployeeRepositoryRepository);

            string searchText = "Bob";

            A.CallTo(() => fakeEmployeeRepositoryRepository.GetEmployees(searchText)).Returns(new List<Employee>());

            var result = employeeService.GetEmployees(searchText);

            Assert.IsEmpty(result);
        }

        [Test]
        public void WhenTheGetEmployeesStringOverloadIsCalledAndTheEmployeeRepositoryGetEmployeesMethodReturnsOneEmployeeThenOneEmployeeIsReturned()
        {
            var fakeEmployeeRepositoryRepository = A.Fake<IEmployeeRepository>();

            var employeeService = new EmployeeService(fakeEmployeeRepositoryRepository);

            string searchText = "Bob";

            A.CallTo(() => fakeEmployeeRepositoryRepository.GetEmployees(searchText)).Returns(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Firstname = "Bob",
                    Surname = "Smith",
                    WorkEmail = "bob.smith@ert.com",
                    PersonalEmail = "bob.smith@paxium.com",
                    StartDate = DateTime.Now.AddDays(-100),
                    EnteredByUserId = 1
                }
            });

            var result = employeeService.GetEmployees(searchText);

            Assert.AreEqual(result.Count(), 1);
        }

        [Test]
        public void WhenTheGetEmployeesStringOverloadIsCalledAndTheEmployeeRepositoryGetEmployeesMethodReturnsTwoEmployeesThenTwoEmployeesAreReturned()
        {
            var fakeEmployeeRepositoryRepository = A.Fake<IEmployeeRepository>();

            var employeeService = new EmployeeService(fakeEmployeeRepositoryRepository);

            string searchText = "Bob";

            A.CallTo(() => fakeEmployeeRepositoryRepository.GetEmployees(searchText)).Returns(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Firstname = "Bob",
                    Surname = "Smith",
                    WorkEmail = "bob.smith@ert.com",
                    PersonalEmail = "bob.smith@paxium.com",
                    StartDate = DateTime.Now.AddDays(-100),
                    EnteredByUserId = 1
                },
                new Employee
                {
                    Id = 1,
                    Firstname = "Bob",
                    Surname = "Williams",
                    WorkEmail = "bob.williams@ert.com",
                    PersonalEmail = "bob.williams@paxium.com",
                    StartDate = DateTime.Now.AddDays(-120),
                    EnteredByUserId = 1
                }
            });

            var result = employeeService.GetEmployees(searchText);

            Assert.AreEqual(result.Count(), 1);
        }

        [Test]
        public void WhenTheGetEmployeesStringOverloadIsCalledAndTheEmployeeRepositoryGetEmployeesMethodReturnsOneEmployeeThenOneEmployeeIsReturnedWithTheCorrectId()
        {
            var fakeEmployeeRepositoryRepository = A.Fake<IEmployeeRepository>();

            var employeeService = new EmployeeService(fakeEmployeeRepositoryRepository);

            string searchText = "Bob";

            A.CallTo(() => fakeEmployeeRepositoryRepository.GetEmployees(searchText)).Returns(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Firstname = "Bob",
                    Surname = "Smith",
                    WorkEmail = "bob.smith@ert.com",
                    PersonalEmail = "bob.smith@paxium.com",
                    StartDate = DateTime.Now.AddDays(-100),
                    EnteredByUserId = 1
                }
            });

            var result = employeeService.GetEmployees(searchText).ToList();

            Assert.AreEqual(result[0].Id, 1);
        }

        [Test]
        public void WhenTheGetEmployeesStringOverloadIsCalledAndTheEmployeeRepositoryGetEmployeesMethodReturnsOneEmployeeThenOneEmployeeIsReturnedWithTheCorrectFirstname()
        {
            var fakeEmployeeRepositoryRepository = A.Fake<IEmployeeRepository>();

            var employeeService = new EmployeeService(fakeEmployeeRepositoryRepository);

            string searchText = "Bob";

            A.CallTo(() => fakeEmployeeRepositoryRepository.GetEmployees(searchText)).Returns(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Firstname = "Bob",
                    Surname = "Smith",
                    WorkEmail = "bob.smith@ert.com",
                    PersonalEmail = "bob.smith@paxium.com",
                    StartDate = DateTime.Now.AddDays(-100),
                    EnteredByUserId = 1
                }
            });

            var result = employeeService.GetEmployees(searchText).ToList();

            Assert.AreEqual(result[0].Firstname, "Bob");
        }

        [Test]
        public void WhenTheGetEmployeesStringOverloadIsCalledAndTheEmployeeRepositoryGetEmployeesMethodReturnsOneEmployeeThenOneEmployeeIsReturnedWithTheCorrectSurname()
        {
            var fakeEmployeeRepositoryRepository = A.Fake<IEmployeeRepository>();

            var employeeService = new EmployeeService(fakeEmployeeRepositoryRepository);

            string searchText = "Bob";

            A.CallTo(() => fakeEmployeeRepositoryRepository.GetEmployees(searchText)).Returns(new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Firstname = "Bob",
                    Surname = "Smith",
                    WorkEmail = "bob.smith@ert.com",
                    PersonalEmail = "bob.smith@paxium.com",
                    StartDate = DateTime.Now.AddDays(-100),
                    EnteredByUserId = 1
                }
            });

            var result = employeeService.GetEmployees(searchText).ToList();

            Assert.AreEqual(result[0].Firstname, "Smith");
        }
    }
}
