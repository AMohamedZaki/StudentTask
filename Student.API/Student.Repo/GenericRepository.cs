﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
    // set the common methods in repo (CRUD)
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext _dbContext;
        protected readonly IDbSet<T> entity;
        public GenericRepository(DbContext dbContext)
        {
            // The Current Context 
            _dbContext = dbContext;
            entity = _dbContext.Set<T>();
        }
        public T Add(T entity)
        {
            return this.entity.Add(entity);
        }

        public T Delete(T entity)
        {
            return this.entity.Remove(entity);
        }

        public void Edit(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> experssion)
        {
            return entity.Where(experssion).AsQueryable<T>();
        }

        public IQueryable<T> GetAll()
        {
            return entity.AsQueryable<T>();
        }

    }
}
