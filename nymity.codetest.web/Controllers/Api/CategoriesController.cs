using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;
using nymity.codetest.web.ViewModels;

namespace nymity.codetest.web.Controllers.Api
{
    [RoutePrefix("api/categories")]
    public class CategoriesController : ApiController
    {
        private ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        public IHttpActionResult Get()
        {
            var categories = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(_service.GetAll());
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpGet]
        [Route("{id:int}/products")]
        public IHttpActionResult GetProducts(int id)
        {
            var products = Mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel>>(_service.GetProducts(id).Products);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

    }
}
