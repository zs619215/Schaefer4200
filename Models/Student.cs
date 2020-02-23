using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schaefer4200.Models
{
    public class Student
    {
     
    
        public System.Guid SID  { get; set; }
        public int studentId { get; set; }
 
        [Display (Name="First Name")]
        [Required(ErrorMessage = "Student first name is required")]
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

        
        [Display (Name="Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$"), 
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
       
        //need to fix this error
        public string phoneNumber { get; set; }

        
        [Display (Name="Student Course Details")]
        [Required(ErrorMessage = "Student course details is required")]
        [stringLength(20)]


        public ICollection<CourseDetail> CourseDetail { get; set; }

        

   
    }

    
}



    