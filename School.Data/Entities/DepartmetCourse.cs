using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
    public class DepartmetCourse
    {
        [Key]
        public int DepartmentCourseId { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
