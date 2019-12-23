using Student.Model;
using Student.Service;
using Student.Service.interfaces;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
    public class DepartmentService : EntityService<Department>, IDepartmentsService
    {
        public DepartmentService(IUnitOfWork _unitOfWork, IDepartmentRepository departmentRepository) : base(_unitOfWork, departmentRepository)
        {
        }
    }
}
