using System.Linq;
using System.Web.Mvc;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;
using PagedList;

namespace nymity.codetest.web.Controllers
{
    //[Authorize]    
    public class CategoriesController : Controller
    {
        private ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            return View(_service.GetAll().ToPagedList(pageNumber, 5));
        }

        public PartialViewResult Products(int id)
        {            
            Category c = _service.GetProducts(id);
            return PartialView("_Products", c.Products);
        }
    }
}