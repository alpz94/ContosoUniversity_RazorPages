using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_RazorPages.Models
{
    /// <summary>
    /// This model represents a student of Contoso University.
    /// Author: Ana Lucia Petinga Zorro
    /// </summary>
    public class Student
    {
        //Primary Key
        public int StudentID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }
        // Relationship or Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
