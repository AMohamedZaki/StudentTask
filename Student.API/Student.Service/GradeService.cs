using Student.Model;
using Student.Service;
using Student.Service.interfaces;

namespace Student.Repository.interfaces
{

    public class GradeService : EntityService<Grade>, IGradeService
    {
        IUnitOfWork _unitOfWork;
        IGradeRepository _gradeRepository;
        public GradeService(IUnitOfWork unitOfWork, IGradeRepository gradeRepository) : base(unitOfWork, gradeRepository)
        {
            _unitOfWork = unitOfWork;
            _gradeRepository = gradeRepository;
        }
    }
}
