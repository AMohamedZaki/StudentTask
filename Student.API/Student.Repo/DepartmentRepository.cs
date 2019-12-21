using Student.Model;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(DbContext _dbContext): base(_dbContext)
        {

        }
    }
}
