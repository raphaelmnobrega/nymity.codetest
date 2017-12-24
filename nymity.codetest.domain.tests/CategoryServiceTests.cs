using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;
using nymity.codetest.domain.Services;
using nymity.codetest.infra.Repository;

namespace nymity.codetest.domain.tests
{
    [TestClass]
    public class CategoryServiceTests
    {
        private ICategoryService _categoryService;
        private ICategoryRepository _categoryRepository;

        [TestInitialize]
        public void Init()
        {
            _categoryRepository = new CategoryRepository();
            _categoryService = new CategoryService(_categoryRepository);
        }

        [TestMethod]
        public void CheckIfGetListOfCategories()
        {
            Assert.IsTrue(_categoryService.GetAll().Any());
        }

        [TestMethod]
        public void CheckIfListOfCategoriesIsNotNull()
        {
            Assert.IsNotNull(_categoryService.GetAll());
        }

        [TestMethod]
        public void ChackIfIsGattingProductsByCategory()
        {
            Assert.IsTrue(_categoryService.GetProducts(1).Products.Count > 0);           
        }

        [TestMethod]
        public void CheckIfItemsAreCategories()
        {
            CollectionAssert.AllItemsAreInstancesOfType(_categoryService.GetAll().ToList(),  typeof(Category));
           
        }

        [TestMethod]
        public void CheckIfProductsOfACategoryAreProduct()
        {
            CollectionAssert.AllItemsAreInstancesOfType(_categoryService.GetProducts(1).Products.ToList(), typeof(Product));
        }

        [TestMethod]
        public void CheckIfAllProductsOfACategoryAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(_categoryService.GetProducts(1).Products.ToList());
        }

        [TestMethod]
        public void CheckIfCategoriesAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(_categoryService.GetAll().ToList());
        }

    }
}
