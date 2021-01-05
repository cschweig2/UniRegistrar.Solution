namespace UniRegistrar.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int MajorId { get; set; }
        public int DepartmentId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Major Major { get; set; }
        public Department Department { get; set; }
    }
}