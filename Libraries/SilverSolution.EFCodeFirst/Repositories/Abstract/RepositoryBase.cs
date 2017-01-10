using SilverSolution.Core.DataAccess.EntityFramework;
using SilverSolution.Core.Entities;
using SilverSolution.EFCodeFirst.Database;

namespace SilverSolution.EFCodeFirst.Repositories
{
    public abstract class RepositoryBase<TEntity> : EfEntityRepositoryBase<TEntity, SilverSolutionContext>
         where TEntity : class, IEntity, new()
    {

    }
}
