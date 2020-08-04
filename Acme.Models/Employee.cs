using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Acme.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string WorkEmail { get; set; }

        public string PersonalEmail { get; set; }

        public DateTime? StartDate { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Surname}";
        }

        [ForeignKey("EnteredByUser")]
        public int EnteredByUserId { get; set; }
        
        public ApplicationUser EnteredByUser { get; set; }

        public ErrorMessages Validate()
        {
            var errorMessage = new ErrorMessages();

            if (string.IsNullOrEmpty(Firstname))
            {
                errorMessage.Errors.Add("The firstname field must have a value");
            }

            if (string.IsNullOrEmpty(Surname))
            {
                errorMessage.Errors.Add("The surname field must have a value");
            }

            if (string.IsNullOrEmpty(WorkEmail))
            {
                errorMessage.Errors.Add("The work email field must have a value");
            }
            else
            {
                if (WorkEmail.Length < 3)
                {
                    errorMessage.Errors.Add("The work email field must be at least 3 characters");
                }

                if (WorkEmail.Length > 254)
                {
                    errorMessage.Errors.Add("The work email field must be no more than 254 characters");
                }

                if (!WorkEmail.Contains("@"))
                {
                    errorMessage.Errors.Add("The work email field must contain an @ sign");
                }

                if (!WorkEmail.Contains("."))
                {
                    errorMessage.Errors.Add("The work email field must contain a period");
                }
            }

            if (string.IsNullOrEmpty(PersonalEmail))
            {
                errorMessage.Errors.Add("The personal email field must have a value");
            }
            else
            {
                if (PersonalEmail.Length < 3)
                {
                    errorMessage.Errors.Add("The personal email field must be at least 3 characters");
                }

                if (PersonalEmail.Length > 254)
                {
                    errorMessage.Errors.Add("The personal email field must be no more than 254 characters");
                }

                if (!PersonalEmail.Contains("@"))
                {
                    errorMessage.Errors.Add("The personal email field must contain an @ sign");
                }

                if (!PersonalEmail.Contains("."))
                {
                    errorMessage.Errors.Add("The personal email field must contain a period");
                }
            }

            if (!string.IsNullOrEmpty(WorkEmail) && WorkEmail == PersonalEmail)
            {
                errorMessage.Errors.Add("The work and personal email fields cannot be the same");
            }

            if (!StartDate.HasValue)
            {
                errorMessage.Errors.Add("A start date is required");
            }

            return errorMessage;
        }
    }
}
