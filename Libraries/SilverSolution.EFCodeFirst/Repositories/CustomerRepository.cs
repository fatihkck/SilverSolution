using SilverSolution.DataLayer.Abstract.EntityFramework.Repositories;
using SilverSolution.Entities.Concrete;

namespace SilverSolution.EFCodeFirst.Repositories
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
    }
}
