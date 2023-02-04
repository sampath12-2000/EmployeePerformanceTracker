using System.ComponentModel.DataAnnotations;

namespace EmployeePerformanceTracker.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Admin Id")]

        public long AdminId { get; set; }

        [Required, Display(Name = "Name")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password length is inappropriate")]
        public string Password { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }
    }
}
