using System.Collections.Generic;
using System.Linq;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Model;
using nymity.codetest.infra.Context;

namespace nymity.codetest.infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private NorthwindContext _context;

        public NorthwindContext Context
        {
            get
            {
                if(_context == null)
                    _context = new NorthwindContext();
                return _context;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return Context.Categories.ToList();
        }

        public Category GetProducts(int categoryId)
        {
            return Context.Categories.Include("Products").First(c => c.CategoryId == categoryId);
        }
    }
}
