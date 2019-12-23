using Student.Model;
using Student.Service;
using Student.Service.interfaces;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
   
    public class GradeService : EntityService<Grade>, IGradeService
    {
        public GradeService(IUnitOfWork _unitOfWork, IGradeRepository gradeRepository) : base(_unitOfWork, gradeRepository)
        {
        }
    }
}
