using Student.Model;
using Student.Model.interfaces;
using System;
using System.Data.Entity;
using System.Linq;

namespace Student.Infrastructure
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("Name=Studentdb") {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Classes> Classes_ { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentObj> Students { get; set; }
        public override int SaveChanges()
        {
            // You Can Get The modified Data That inhert from BaseEntity Only 
            // Entity.Entity is BaseEntity
            // but I deal with simple example
            var modifiedEntity = ChangeTracker.Entries()
                                              .Where(Entity => Entity.State == EntityState.Modified ||
                                                     Entity.State == EntityState.Added);


            // set Time of data in case of adding and editing
            int entityLength = modifiedEntity.Count();
            if (entityLength > 0)
            {
                foreach (var entity in modifiedEntity)
                {
                    var entityObj = entity.Entity as IBaseEntity;
                    switch (entity.State)
                    {
                        case EntityState.Modified:
                            entityObj.LastUpdate = DateTime.Now;
                            break;
                        case EntityState.Added:
                        default:
                            entityObj.CreatedDate = DateTime.Now;
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
