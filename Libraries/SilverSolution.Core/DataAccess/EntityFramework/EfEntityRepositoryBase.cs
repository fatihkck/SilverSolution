using SilverSolution.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SilverSolution.Core.DataAccess.EntityFramework
{
    public abstract class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> predicate=null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(predicate);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate=null)
        {
            using (var context = new TContext())
            {
                return predicate == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(predicate).ToList();
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

                return addedEntity.Entity;
            }

        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

                return updatedEntity.Entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
