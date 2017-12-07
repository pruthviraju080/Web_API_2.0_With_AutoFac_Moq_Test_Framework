using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Web_Service.Appliation;
using Web_Service.Data;
using Web_Service.Data.Contexts;

namespace Web_Service.API
{
    public class AutofacWebapiConfig
    {
        public static void Configure()
        {
            //Configure AutoFac  
            var builder = new ContainerBuilder();
            //builder.RegisterModule(new DataAccessAutofacModule());
            //builder.RegisterModule(new ApplicationAutofacModule());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<Application>().AsSelf().As<IApplication>().InstancePerRequest();
            builder.RegisterType<Data.Data>().AsSelf().As<IData>().InstancePerRequest();
            builder.RegisterType<NorthWindContext>().AsSelf();
            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        //public static IContainer Container;

        //public static void Intialize(HttpConfiguration config)
        //{
        //    Setup(config, RegisterServices(new ContainerBuilder()));
        //}


        //public static void Setup(HttpConfiguration config, IContainer container)
        //{
        //    config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        //}

        //private static IContainer RegisterServices(ContainerBuilder builder)
        //{
        //    //Register your Web API controllers.  
        //    builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

        //    builder.RegisterType<Application>().AsSelf()
        //        .As<IApplication>()
        //        .InstancePerRequest();

        //    //Set the dependency resolver to be Autofac.  
        //    Container = builder.Build();

        //    return Container;
        //}
    }
}