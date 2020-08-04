using System.Collections.Generic;
using System.Linq;
using Acme.DataAccess.Interfaces;
using Acme.Models;

namespace Acme.DataAccess.Implementations
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        public IEnumerable<ApplicationUser> GetApplicationUsers()
        {
            using (var context = new AcmeDbContext())
            {
                return context.ApplicationUsers.ToList();
            }
        }

        public ApplicationUser GetApplicationUser(string username, string password)
        {
            using (var context = new AcmeDbContext())
            {
                var query = $"Select Id, Username, Password From ApplicationUsers Where Username = '{username}' And Password = '{password}'";

                var user = context.Database.SqlQuery<ApplicationUser>(query).FirstOrDefault();

                return user;
            }
        }

        public void Add(ApplicationUser applicationUser)
        {
            using (var context = new AcmeDbContext())
            {
                context.ApplicationUsers.Add(applicationUser);

                context.SaveChanges();
            }
        }
    }
}
