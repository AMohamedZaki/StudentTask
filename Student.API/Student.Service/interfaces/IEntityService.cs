using System.Collections.Generic;
using Student.Model;
using System.Linq;

namespace Student.Service.interfaces
{

    public interface IEntityService<T> where T : BaseEntity<int>
    {
        T Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
        IQueryable<T> GetAll();
    }
}
