using SilverSolution.Entities.Concrete;
using System.Collections.Generic;

namespace SilverSolution.Business.Services.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category Add(Category category);

      
    }
}
