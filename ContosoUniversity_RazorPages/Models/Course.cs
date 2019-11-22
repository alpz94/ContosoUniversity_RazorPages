using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_RazorPages.Models
{
    /// <summary>
    /// This model represents a course that a student is enrolled on.
    /// Author: Ana Lucia Petinga Zorro
    /// </summary>
    public class Course
    {
        //Primary Key
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }
        // Relationship or Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
