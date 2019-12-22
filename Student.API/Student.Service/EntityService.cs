using Student.Model;
using Student.Repo.interfaces;
using Student.Service.interfaces;
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
        public T Create(T entity)
        {
            if (entity != null)
            {
            var _entity = _dbContext.Set<T>().Add(entity);
            _unitOfWork.SaveChanges();
            return _entity;
            }
            return null;
        }

        public void Delete(T entity)
        {
            if (entity != null)
            {
                _dbContext.Set<T>().Remove(entity);
                _unitOfWork.SaveChanges();
            }
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsQueryable<T>();
        }

        public void Update(T entity)
        {
            if (entity != null)
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _unitOfWork.SaveChanges();
            }
        }

        public T FindById(int Id)
        {
            return _dbContext.Set<T>().Find(Id);
        }
    }
}
