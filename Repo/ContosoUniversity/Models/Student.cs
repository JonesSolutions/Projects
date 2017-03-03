using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student :Person
    {


        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Student's Courses")]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
