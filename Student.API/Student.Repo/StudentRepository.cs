using Student.Model;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
    public class StudentRepository : GenericRepository<StudentObj>
    {
        public StudentRepository(DbContext _dbContext) : base(_dbContext)
        {

        }
    }
}
