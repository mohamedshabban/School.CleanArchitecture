using School.Data.Entities;

namespace School.Infrastructure.Interfaces
{
    public interface IStudentReporsitory
    {
        public Task<List<Student>> GetAllStudentsAsync();
    }
}
