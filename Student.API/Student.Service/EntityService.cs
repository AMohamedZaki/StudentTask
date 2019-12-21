using Student.Model;
using Student.Repo.interfaces;
using Student.Service.interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Student.Service
{
    public class EntityService<T> : IEntityService<T> where T : BaseEntity<int>
    {
        protected IUnitOfWork _unitOfWork;
        private DbContext _dbContext;
        public EntityService(IUnitOfWork unitOfWork, DbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _dbContext = dbContext;
        }
        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsQueryable<T>();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
