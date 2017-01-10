using SilverSolution.Core.DataAccess;
using SilverSolution.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverSolution.DataLayer.Abstract.EntityFramework.Repositories
{
    public interface ICustomerRepository: IEntityRepository<Customer>
    {
    }
}
