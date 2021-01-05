using Microsoft.EntityFrameworkCore;

namespace UniRegistrar.Models
{
    public class UniRegistrarContext : DbContext
    {
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        public UniRegistrarContext(DbContextOptions options) : base(options) { }
    }
}