using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Model;
using nymity.codetest.infra.Context;

namespace nymity.codetest.infra.Repository
{
    public class ProductRepository: RepositoryBase<NorthwindContext>, IProductRepository
    {
        public ProductRepository(NorthwindContext context) : base(context)
        {
        }

        public ICollection<Product> GetProductsByCategory(int categoryId)
        {
            return Context.Products.Include("Category").Where(c => c.CategoryId == categoryId).ToList();
        }
    }
}
