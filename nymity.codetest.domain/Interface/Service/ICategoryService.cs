using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nymity.codetest.domain.Model;

namespace nymity.codetest.domain.Interface.Service
{
    public interface ICategoryService
    {
        ICollection<Category> GetAll();
    }
}
