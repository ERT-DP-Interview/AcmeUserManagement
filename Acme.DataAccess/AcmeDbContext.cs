using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Acme.Models;

namespace Acme.DataAccess
{
    public class AcmeDbContext : DbContext
    {
        public AcmeDbContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
