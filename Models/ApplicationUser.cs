using EnrollmentSystem.Models.Enum;
using Microsoft.AspNetCore.Identity;

namespace EnrollmentSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public Programs? Program { get; set; }

    }
}
