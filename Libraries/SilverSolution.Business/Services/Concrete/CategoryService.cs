using SilverSolution.Business.Services.Abstract;
using System.Collections.Generic;
using SilverSolution.Entities.Concrete;
using SilverSolution.DataLayer.Abstract.EntityFramework.Repositories;

namespace SilverSolution.Business.Services.Concrete
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Add(Category category)
        {
            return _categoryRepository.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetList();
        }
    }
}
