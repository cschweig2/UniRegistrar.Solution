using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace UniRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Enrollment>();
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Courses { get; }
    }
}