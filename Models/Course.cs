using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schaefer4200.Models
{
    public class Course
    {
        public int courseID { get; set; }



        [Display (Name="Course Name")]
        [Required(ErrorMessage = "Course name is required")]
        [stringLength(20)]
        public string courseName { get; set; }

        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}