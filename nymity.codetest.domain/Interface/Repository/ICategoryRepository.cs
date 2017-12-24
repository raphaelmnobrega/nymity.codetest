using System.Collections.Generic;
using nymity.codetest.domain.Model;

namespace nymity.codetest.domain.Interface.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetProducts(int categoryId);
    }
}
