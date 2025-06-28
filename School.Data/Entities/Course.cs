using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
    public class Course
    {
        public Course()
        {
            StudentsCourses = new HashSet<StudentCourse>();
            DepartmetsCourses = new HashSet<DepartmetCourse>();
        }
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        public DateTime Period { get; set; }
        public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
        public virtual ICollection<DepartmetCourse> DepartmetsCourses { get; set; }
    }
}
