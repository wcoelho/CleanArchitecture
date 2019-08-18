namespace Ativ5.Infrastructure.Modules
{
    using Autofac;
    using Ativ5.Application;
	using System.Reflection;

    public class WebApiModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in Ativ5.WebApi
            //
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly())
                .AsClosedTypesOf(typeof(IOutputBoundary<>))
                .InstancePerLifetimeScope();
        }
    }
}
