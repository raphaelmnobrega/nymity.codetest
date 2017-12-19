using System.Web.Mvc;
using nymity.codetest.domain.Interface.Service;

namespace nymity.codetest.web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ProductByCategory(int id)
        {
            return View(_service.GetProductsByCategory(id));
        }
    }
}