using System.Collections.Generic;
using nymity.codetest.domain.Model;

namespace nymity.codetest.domain.Interface.Service
{
    public interface IProductService
    {
        ICollection<Product> GetProductsByCategory(int categoryId);
    }
}
