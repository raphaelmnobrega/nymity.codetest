using System.Web.Mvc;
using nymity.codetest.domain.Interface.Service;

namespace nymity.codetest.web.Controllers
{
    public class ProductsController : Controller
    {
        private ICategoryService _service;

        public ProductsController(ICategoryService service)
        {
            _service = service;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ProductByCategory()
        {
            return View(_service.GetAll());
        }
    }
}