using System.ComponentModel.DataAnnotations;

namespace TestDotnet.Models
{
    public class Form
    {
        [Required]
        [StringLength(100, MinimumLength =4)]
        public string Name { get; set; }
    }
}
