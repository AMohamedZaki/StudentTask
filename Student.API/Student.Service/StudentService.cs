using Student.Service;
using Student.Service.interfaces;

namespace Student.Repository.interfaces
{

    public class StudentService : EntityService<Model.StudentInformation>, IStudentService
    {
        IUnitOfWork _unitOfWork;
        IStudentRepository _studentRepository;
        public StudentService(IUnitOfWork unitOfWork, IStudentRepository studentRepository) : base(unitOfWork, studentRepository)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
        }
    }
}
