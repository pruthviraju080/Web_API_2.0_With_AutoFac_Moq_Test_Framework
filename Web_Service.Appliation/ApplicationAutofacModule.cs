using Autofac;

namespace Web_Service.Appliation
{
    public class ApplicationAutofacModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Application>().As<IApplication>(); 
        }
    }
}
