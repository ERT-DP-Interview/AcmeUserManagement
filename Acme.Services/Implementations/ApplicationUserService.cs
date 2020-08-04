using System.Linq;
using Acme.DataAccess.Implementations;
using Acme.DataAccess.Interfaces;
using Acme.Models;

namespace Acme.Services.Implementations
{
    public class ApplicationUserService
    {
        protected IApplicationUserRepository ApplicationUserRepository;

        public ApplicationUserService()
        {
            ApplicationUserRepository = new ApplicationUserRepository();
        }

        public ApplicationUserService(IApplicationUserRepository applicationUserRepository)
        {
            ApplicationUserRepository = applicationUserRepository;
        }

        public bool ValidateCredentials(string username, string password)
        {
            var user = ApplicationUserRepository.GetApplicationUser(username, password);

            return user != null;
        }

        public void SeedApplicationUsers()
        {
            var applicationUserRepository = new ApplicationUserRepository();

            if (applicationUserRepository.GetApplicationUsers().Any())
            {
                return;
            }

            applicationUserRepository.Add(new ApplicationUser { Username = "Dave", Password = "Password"});
        }
    }
}
