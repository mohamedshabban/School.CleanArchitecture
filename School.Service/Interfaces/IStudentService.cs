using School.Data.Entities;

namespace School.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<List<Student>> GetAllStudentsAsync();
    }
}
