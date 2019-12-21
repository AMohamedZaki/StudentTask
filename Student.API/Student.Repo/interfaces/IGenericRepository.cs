using System;
using System.Linq;
using System.Linq.Expressions;

namespace Student.Repo.interfaces
{
    // set the common methods in repo (CRUD)
    public interface IGenericRepository<T> 
    {
        T Add(T entity);
        void Edit(T entity);
        T Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T,bool>> experssion);
    }
}
