using Acme.DataAccess.Interfaces;
using Acme.Models;
using Acme.Services.Implementations;
using FakeItEasy;
using NUnit.Framework;

namespace Acme.Services.Tests
{
    [TestFixture]
    public class ApplicationUserServiceTests
    {
        [Test]
        public void WhenTheValidateCredentialsMethodIsCalledAndTheApplicationUserRepositoryReturnsAUserThenTrueShouldBeReturned()
        {
            var fakeApplicationUserRepository = A.Fake<IApplicationUserRepository>();

            var applicationUserService = new ApplicationUserService(fakeApplicationUserRepository);

            string username = "Bob";
            string password = "GoodPassword";

            A.CallTo(() => fakeApplicationUserRepository.GetApplicationUser(username, password)).Returns(
                new ApplicationUser
                {
                    Id = 1,
                    Username = username,
                    Password = password
                });

            var result = applicationUserService.ValidateCredentials(username, password);

            Assert.IsTrue(result);
        }

        [Test]
        public void WhenTheValidateCredentialsMethodIsCalledAndTheApplicationUserRepositoryReturnsAUserThenFalseShouldBeReturned()
        {
            var fakeApplicationUserRepository = A.Fake<IApplicationUserRepository>();

            var applicationUserService = new ApplicationUserService(fakeApplicationUserRepository);

            string username = "Bob";
            string password = "BadPassword";

            A.CallTo(() => fakeApplicationUserRepository.GetApplicationUser(username, password)).Returns(null);

            var result = applicationUserService.ValidateCredentials(username, password);

            Assert.IsFalse(result);
        }
    }
}
