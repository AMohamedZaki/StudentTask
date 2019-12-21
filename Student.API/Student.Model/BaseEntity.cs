using Student.Model.interfaces;
using System;

namespace Student.Model
{
    public abstract class BaseEntity<T> : IIdentifer<T>, IBaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public T Id { get; set; }
    }
}
