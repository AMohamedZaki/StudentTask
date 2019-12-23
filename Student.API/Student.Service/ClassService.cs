using Student.Model;
using Student.Service;
using Student.Service.interfaces;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
    public class ClassService : EntityService<Classes>, IClassService
    {
        public ClassService(IUnitOfWork _unitOfWork, IClassRepository classRepository): base(_unitOfWork, classRepository)
        {
        }
    }
}
