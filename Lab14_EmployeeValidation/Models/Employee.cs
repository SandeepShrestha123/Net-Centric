using System.ComponentModel.DataAnnotations;
namespace Lab14_EmployeeValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be 2-50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(10000, 1000000, ErrorMessage = "Salary must be between 10,000 and 1,000,000")]
        public double Salary { get; set; }
    }
}