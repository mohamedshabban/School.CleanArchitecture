using School.Data.Entities;
using School.Infrastructure.Interfaces;
using School.Service.Interfaces;

namespace School.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentReporsitory _reporsitory;

        public StudentService(IStudentReporsitory reporsitory)
        {
            _reporsitory = reporsitory;
        }
        public Task<List<Student>> GetAllStudentsAsync()
            => _reporsitory.GetAllStudentsAsync();
    }
}
