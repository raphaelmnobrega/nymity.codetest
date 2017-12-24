﻿using System.Collections.Generic;
using nymity.codetest.domain.Model;

namespace nymity.codetest.domain.Interface.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category GetProducts(int categoryId);
    }
}
