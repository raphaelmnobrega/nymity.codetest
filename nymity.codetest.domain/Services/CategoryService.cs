using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;

namespace nymity.codetest.domain.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public ICollection<Category> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
