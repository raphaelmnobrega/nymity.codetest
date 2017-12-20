using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.Owin;
using nymity.codetest.domain.Model;
using nymity.codetest.web.ViewModels;
using Owin;

[assembly: OwinStartup(typeof(nymity.codetest.web.Startup))]

namespace nymity.codetest.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CategoryViewModel, Category>();
                cfg.CreateMap<ProductViewModel, Product>();
            });
        }
    }
}
