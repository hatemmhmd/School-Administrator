using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace School_Administrator.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [DisplayName("Student Number")]
        public int StudentNumber { get; set; }

        [Required]
        public string Grade { get; set; } = string.Empty;
    }
}
