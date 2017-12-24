using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nymity.codetest.domain.Interface.Repository;
using nymity.codetest.domain.Interface.Service;
using nymity.codetest.domain.Model;
using nymity.codetest.domain.Services;
using nymity.codetest.infra.Repository;
using nymity.codetest.web.Controllers;
using nymity.codetest.web.ViewModels;

namespace nymity.codetest.web.Tests.Controllers
{
    [TestClass]
    public class CategoriesControllerTest
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
        public void Index()
        {
            // Arrange
            CategoriesController controller = new CategoriesController(_categoryService);

            // Act
            ViewResult result = controller.Index(null) as ViewResult;
            //Mapper.Reset();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PublicPage()
        {
            // Arrange
            CategoriesController controller = new CategoriesController(_categoryService);

            // Act
            ViewResult result = controller.PublicPage() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Products()
        {
            // Arrange
            CategoriesController controller = new CategoriesController(_categoryService);

            // Act
            PartialViewResult result = controller.Products(1) as PartialViewResult;
            //Mapper.Reset();

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
