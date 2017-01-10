using SilverSolution.Entities.Abstract;
using SilverSolution.Entities.Concrete;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;

namespace SilverSolution.EFCodeFirst.Database
{
    public class SilverSolutionContext : DbContext
    {

        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }



        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    var builder = Assembly
        //        .GetExecutingAssembly()
        //        .GetTypes();

        //    var builderClas = builder
        //        .Where(p => p.IsClass
        //            && p.Name.EndsWith("Configuration")
        //            && p.BaseType.Name == typeof(BaseConfiguration<>).Name
        //            ).ToList();

        //    foreach (var type in builderClas)
        //    {
        //        dynamic configurationInstance = Activator.CreateInstance(type);
        //        modelBuilder.Configurations.Add(configurationInstance);
        //    }
        //}

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in entries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.Now;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
        public virtual void Commit()
        {
            SaveChanges();
        }

    }
}
