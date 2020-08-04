using System.Collections.Generic;
using Acme.Models;

namespace Acme.DataAccess.Interfaces
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetApplicationUsers();
        ApplicationUser GetApplicationUser(string username, string password);
        void Add(ApplicationUser applicationUser);
    }
}