using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;

namespace nymity.codetest.domain.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public ICollection<Product> GetProductsByCategory(int categoryId)
        {
            return _repository.GetProductsByCategory(categoryId);
        }
    }
}
