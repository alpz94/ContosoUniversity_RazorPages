﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_RazorPages.Models
{
    /// <summary>
    /// This model represents a student enrolled on a course.
    /// Author: Ana Lucia Petinga Zorro
    /// </summary>
    public class Enrollment
    {
        //Primary Key
        public int EnrollmentID { get; set; }
        //Foreign Key
        public int CourseID { get; set; }
        //Foreign Key
        public int StudentID { get; set; }

        public Grades? Grade { get; set; }

        // Relationship or Navigation Property
        public virtual Course Course { get; set; }
        // Relationship or Navigation Property
        public virtual Student Student { get; set; }

    }
    public enum Grades
    {
        First,
        UpperSecond,
        LowerSecond,
        Third,
        Pass,
        Fail
    }
}
