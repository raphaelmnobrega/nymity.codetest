using System.Web.Mvc;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;

namespace nymity.codetest.web.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        // GET: Categories
        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        public PartialViewResult Products(int id)
        {
            Category c = _service.GetProducts(id);
            return PartialView("_Products", c.Products);
        }
    }
}