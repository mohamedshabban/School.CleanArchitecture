using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Repositories
{
    public class StudentReporsitory : IStudentReporsitory
    {
        private readonly AppDBContext _dbContext;

        public StudentReporsitory(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        => await _dbContext.Students.ToListAsync();
    }
}
