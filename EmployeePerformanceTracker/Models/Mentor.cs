using System.ComponentModel.DataAnnotations;

namespace EmployeePerformanceTracker.Models
{
    public class Mentor
    {
        [Key]
        public int Id { get; set; }

        [Required,Display(Name ="Mentor Id")]

        public long MentorId { get; set; }

        [Required,Display(Name ="Name")]
        public string MentorName { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        [Display(Name ="Email Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Phone Number.")]
        [Display(Name = "Phone Number")]
        public string PhoneNo { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password length is inappropriate")]
        public string Password { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

    }
}
