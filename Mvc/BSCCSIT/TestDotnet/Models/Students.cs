using System.ComponentModel.DataAnnotations;

namespace TestDotnet.Models
{
    public class Students
    {
        [Key]
        public Guid Id { get; set; }    
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [Required(ErrorMessage = "Email address is required.")]
        public string Email { get; set; }
        public string Semester { get; set; }
        public double Cgpa { get; set; }
        public double package { get; set; }
    }
}
