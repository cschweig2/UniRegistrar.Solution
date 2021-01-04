using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniRegistrar.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Enrollment>();
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public ICollection<Enrollment> Students { get; set; }
    }
}