using Student.Model;
using Student.Repository.interfaces;
using Student.Service.interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Student.Service
{
    public class EntityService<T> : IEntityService<T> where T : BaseEntity<int>
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public T Create(T entity)
        {
            if (entity != null)
            {
                var _entity = _repository.Add(entity);
                _unitOfWork.SaveChanges();
                return _entity;
            }
            return null;
        }

        public void Delete(T entity)
        {
            if (entity != null)
            {
                _repository.Delete(entity);
                _unitOfWork.SaveChanges();
            }
        }

        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T entity)
        {
            if (entity != null)
            {
                _repository.Edit(entity);
                _unitOfWork.SaveChanges();
            }
        }

        public T FindById(int Id)
        {
            return _repository.FindById(Id);
        }
    }
}
