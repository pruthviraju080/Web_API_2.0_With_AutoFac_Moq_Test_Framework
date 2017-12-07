using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Web_Service.Appliation;
using Web_Service.Appliation.Entities;
using Web_Service.API.Models;
using Web_Service.Data;
using Web_Service.Data.DatabaseModels;
using Web_Services.Api.Models;

namespace Web_Service.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Configuring Autofac - Dependency Injection
            AutofacWebapiConfig.Configure();

            //Configure Automapper
            AutoMapperConfiguration.Configure();
        }

    }


    // Initializing the AutoMappers 
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingProfile>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }

    //Adding Profiles to map.
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerEntity, CustomerModel>();
            CreateMap<Customer, CustomerEntity>();
        }
    }
}
