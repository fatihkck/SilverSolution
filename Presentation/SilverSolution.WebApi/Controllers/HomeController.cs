using SilverSolution.Business.Services.Abstract;
using SilverSolution.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SilverSolution.WebApi.Controllers
{
    public class HomeController : ApiController
    {


        ICategoryService _categoryService;

        public HomeController()
        {

        }

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryService.GetAll().ToArray();
        }
    }
}
