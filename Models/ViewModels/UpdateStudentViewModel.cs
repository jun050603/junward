using EnrollmentSystem.Models.Enum;

namespace EnrollmentSystem.Models.ViewModels
{
    public class UpdateStudentViewModel
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public Programs? Program { get; set; }
    }
}
