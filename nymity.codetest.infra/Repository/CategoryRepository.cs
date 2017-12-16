using System.Collections.Generic;
using System.Linq;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Model;
using nymity.codetest.infra.Context;

namespace nymity.codetest.infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private NorthwindContext db = new NorthwindContext();

        public ICollection<Category> GetAll()
        {
            return db.Categories.ToList();
        }
    }
}
