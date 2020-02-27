using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schaefer4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }


        [Display (Name="First Name")]
        [Required(ErrorMessage = "Instructor first name is required")]
        [stringLength(20)]
        public string firstName { get; set; }

        [DisplayName ("Last Name")]
        [Required]
        [stringLength(20)]
        public string lastName { get; set; }

         [Display (Name="Most used email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string email { get; set; }

        [Display (Name = "Instructor Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", 
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }

        public ICollection<Course> Course { get; set; }

    }
}