using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schaefer4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }



        [Display (name ="When did you join the organization?")]
        [Datatype(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]

        public DateTime startDate { get; set; }


        [Display (name = "When did you last pay dues (leave blank if you never have)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime endDate { get; set; }


        [StringLength(50)]
        [Required]
        public string location { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}