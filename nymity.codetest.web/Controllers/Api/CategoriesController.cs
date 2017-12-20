using System.Collections.Generic;
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

        public IEnumerable<CategoryViewModel> Get()
        {
            var categories = Mapper.Map<IEnumerable<Category>,IEnumerable<CategoryViewModel>>(_service.GetAll());
            return categories;
        }

        [HttpGet]
        [Route("{id:int}/products")]
        public IEnumerable<ProductViewModel> GetProducts(int id)
        {
            var products = Mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel>>(_service.GetProducts(id).Products);
            return products;
        }

        // POST: api/Categories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
        }
    }
}
