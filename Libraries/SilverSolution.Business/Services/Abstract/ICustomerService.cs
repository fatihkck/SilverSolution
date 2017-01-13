using SilverSolution.Entities.Concrete;
using System.Collections.Generic;

namespace SilverSolution.Business.Services.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer Get(int id);

    }
}
