using Student.Model;
using System.Data.Entity;
using System.Linq;

namespace Student.Repository.interfaces
{
    public class StudentRepository : GenericRepository<StudentInformation>, IStudentRepository
    {
        public StudentRepository(DbContext _dbContext) : base(_dbContext)
        {
        }


        public override IQueryable<StudentInformation> GetAll()
        {
            return entity
                .Include(x => x.Classes)
                .Include(x => x.Departments)
                .Include(x => x.Grades)
                .Select(x => new StudentInformation
                {
                    Name = x.Name,
                    DateOfBirth = x.DateOfBirth,
                    Address = x.Address,
                    Email = x.Email,
                    Grades = x.Grades,
                    GradeId= x.Grades.Id,
                    ClassId = x.Classes.Id,
                    Classes = x.Classes,
                    DepartmentId = x.Departments.Id,
                    Departments = new Department { Name =  x.Departments.Name , Id = x.Departments.Id }
                })
                .AsQueryable();
        }
    }
}
