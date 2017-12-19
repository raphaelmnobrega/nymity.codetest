using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;

namespace nymity.codetest.web.Controllers.Api
{
    public class CategoriesController : ApiController
    {
        private ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        // GET: api/Categories
        public ICollection<Category> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Categories/5
        public string Get(int id)
        {
            return "value";
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
