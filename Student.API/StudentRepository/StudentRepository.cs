using Student.Model;
using System.Data.Entity;
using System.Linq;

namespace Student.Repository.interfaces
{
    public class StudentRepository : GenericRepository<StudentObj>
    {
        public StudentRepository(DbContext _dbContext) : base(_dbContext)
        {

        }

        public override IQueryable<StudentObj> GetAll()
        {
            return entity
                .Include(x => x.Classes_)
                .Include(x => x.DepartmentId)
                .Include(x => x.Grades).AsQueryable();
        }
    }
}
