using Microsoft.EntityFrameworkCore;
using School.Data.Entities;

namespace School.Infrastructure.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmetCourse> DepartmetCourses { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
