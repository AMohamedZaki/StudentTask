using Student.Model;
using System.Data.Entity;

namespace Student.Repository.interfaces
{
    public class GradeRepository: GenericRepository<Grade>, IGradeRepository
    {
        public GradeRepository(DbContext _dbContext): base(_dbContext)
        { }
    }
}
