using System.Collections.Generic;

namespace Acme.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICollection<Employee> EnteredEmployees { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
