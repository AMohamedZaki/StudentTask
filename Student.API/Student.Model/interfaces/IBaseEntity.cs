using System;

namespace Student.Model.interfaces
{
    public interface IBaseEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime? LastUpdate { get; set; }
    }
}
