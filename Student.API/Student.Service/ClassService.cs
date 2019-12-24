using Student.Model;
using Student.Service;
using Student.Service.interfaces;

namespace Student.Repository.interfaces
{
    public class ClassService : EntityService<Classes>, IClassService
    {
        IUnitOfWork _unitOfWork;
        IClassRepository _classRepository;
        public ClassService(IUnitOfWork unitOfWork, IClassRepository classRepository): base(unitOfWork, classRepository)
        {
            _unitOfWork = unitOfWork;
            _classRepository = classRepository;
        }
    }
}
