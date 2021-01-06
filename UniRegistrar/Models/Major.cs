using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniRegistrar.Models
{
    public class Major
    {
        public Major()
        {
            this.Courses = new HashSet<Enrollment>();
            // this.Departments = new HashSet<Enrollment>();
        }
        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public virtual ICollection<Enrollment> Courses { get; set; }
        // public ICollection<Enrollment> Departments { get; set; }
    }
}