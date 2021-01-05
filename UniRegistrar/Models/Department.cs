using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniRegistrar.Models
{
    public class Department
    {
        public Department()
        {
            this.Majors = new HashSet<Enrollment>();
        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Enrollment> Majors { get; set; }
    }
}