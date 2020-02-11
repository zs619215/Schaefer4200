using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schaefer4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string location { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}