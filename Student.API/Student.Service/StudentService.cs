using Student.Model;
using Student.Service;
using Student.Service.interfaces;

namespace Student.Repo.interfaces
{

    public class StudentService : EntityService<StudentObj>, IStudentService
    {
        public StudentService(IUnitOfWork _unitOfWork, IStudentRepository studentRepository) : base(_unitOfWork, studentRepository)
        {
        }
    }
}
