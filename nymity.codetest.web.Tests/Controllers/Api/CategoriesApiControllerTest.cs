using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Routing;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;
using nymity.codetest.domain.Services;
using nymity.codetest.infra.Repository;
using nymity.codetest.web.Controllers.Api;
using nymity.codetest.web.ViewModels;
using RouteParameter = System.Web.UI.WebControls.RouteParameter;

namespace nymity.codetest.web.Tests.Controllers.Api
{
    [TestClass]
    public class CategoriesApiControllerTest
    {
        private ICategoryService _categoryService;
        private ICategoryRepository _categoryRepository;

        [TestInitialize]
        public void Init()
        {
            _categoryRepository = new CategoryRepository();
            _categoryService = new CategoryService(_categoryRepository);

            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CategoryViewModel, Category>();
                cfg.CreateMap<ProductViewModel, Product>();
            });
        }

        [TestMethod]
        public void TestResponseOkForCategories()
        {
            // Arrange
            CategoriesController controller = new CategoriesController(_categoryService);
          
            // Act
            var contentResult = controller.Get() as OkNegotiatedContentResult<IEnumerable<CategoryViewModel>>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            
        }

        [TestMethod]
        public void TestResponseOkForProductsOfCategories()
        {
            //Arrange
            CategoriesController controller = new CategoriesController(_categoryService);

            // Act
            var contentResult = controller.GetProducts(1) as OkNegotiatedContentResult<IEnumerable<ProductViewModel>>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
        }
    }


}
