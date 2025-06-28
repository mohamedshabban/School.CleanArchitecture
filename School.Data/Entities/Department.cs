using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();//Hashset to avoid duplication
            DepartmentCourses = new HashSet<DepartmetCourse>();
        }
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmetCourse> DepartmentCourses { get; set; }
    }
}
