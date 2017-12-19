using System.Collections.Generic;
using System.Linq;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Model;
using nymity.codetest.infra.Context;

namespace nymity.codetest.infra.Repository
{
    public class CategoryRepository : RepositoryBase<NorthwindContext>, ICategoryRepository
    {
        public CategoryRepository(NorthwindContext context) : base(context)
        {
        }

        public ICollection<Category> GetAll()
        {
            return Context.Categories.ToList();
        }

        public Category GetProducts(int categoryId)
        {
            return Context.Categories.Include("Products").First(c => c.CategoryId == categoryId);
        }
    }
}
