using Student.Model;
using Student.Service;
using Student.Service.interfaces;

namespace Student.Repository.interfaces
{
    public class DepartmentService : EntityService<Department>, IDepartmentsService
    {
        IUnitOfWork _unitOfWork;
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IUnitOfWork unitOfWork, IDepartmentRepository departmentRepository) : base(unitOfWork, departmentRepository)
        {
            _unitOfWork = unitOfWork;
            _departmentRepository = departmentRepository;
        }
    }
}
