using SilverSolution.Business.Services.Abstract;
using System.Collections.Generic;
using SilverSolution.Entities.Concrete;
using SilverSolution.DataLayer.Abstract.EntityFramework.Repositories;

namespace SilverSolution.Business.Services.Concrete
{
    public class CustomerService : ICustomerService
    {

        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Get(int id)
        {

            return _customerRepository.Get(p => p.Id == id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetList();
        }
    }
}
