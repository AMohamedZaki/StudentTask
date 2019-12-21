﻿using System.Collections.Generic;
using Student.Model;
using System.Linq;

namespace Student.Service.interfaces
{

    public interface IEntityService<T> where T : BaseEntity<int>
    {
        void Create(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        void Update(T entity);
    }
}