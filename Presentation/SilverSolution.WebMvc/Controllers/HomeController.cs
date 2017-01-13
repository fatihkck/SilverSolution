using SilverSolution.Business.Services.Abstract;
using System.Web.Mvc;

namespace SilverSolution.WebMvc.Controllers
{
    public class HomeController : Controller
    {

        ICategoryService _categoryService;

        public HomeController()
        {

        }

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Home
        public ActionResult Index()
        {

            var categoryList = _categoryService.GetAll();
            foreach (var item in categoryList)
            {
                Response.Write(item.Name + " <br>");
            }

            return Content("Ok");
        }
    }
}