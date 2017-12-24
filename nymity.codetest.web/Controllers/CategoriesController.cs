using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;
using nymity.codetest.web.ViewModels;
using PagedList;

namespace nymity.codetest.web.Controllers
{
     
    public class CategoriesController : Controller
    {
        private ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [Authorize]
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            var categories = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(_service.GetAll());
            if (categories == null)
            {
                return null;
            }
            return View(categories.ToPagedList(pageNumber, 5));
        }

        [Authorize]
        public PartialViewResult Products(int id)
        {   
            var products = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_service.GetProducts(id).Products);
            if (products == null)
            {
                return null;
            }
            return PartialView("_Products", products);
        }

        public ActionResult PublicPage()
        {
            return View();
        }

        
    }
}