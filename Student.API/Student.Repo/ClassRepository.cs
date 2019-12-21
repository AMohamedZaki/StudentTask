﻿using Student.Model;
using System.Data.Entity;

namespace Student.Repo.interfaces
{
    public class ClassRepository : GenericRepository<Classes>
    {
        public ClassRepository(DbContext _dbContext): base(_dbContext)
        {

        }
    }
}
