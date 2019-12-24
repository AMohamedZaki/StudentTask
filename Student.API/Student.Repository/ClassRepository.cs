using Student.Model;
using System.Data.Entity;

namespace Student.Repository.interfaces
{
    public class ClassRepository : GenericRepository<Classes>, IClassRepository
    {
        public ClassRepository(DbContext _dbContext): base(_dbContext)
        {

        }
    }
}
