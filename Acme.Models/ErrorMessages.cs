using System.Collections.Generic;
using System.Linq;

namespace Acme.Models
{
    public class ErrorMessages
    {
        public ErrorMessages()
        {
            Errors = new List<string>();
        }

        public List<string> Errors { get; set; }

        public bool IsValid => !Errors.Any();
    }
}
