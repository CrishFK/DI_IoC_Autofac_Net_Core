using Autofac;
using DI_IoC_Autofac_Net_Core.Models;

namespace DI_IoC_Autofac_Net_Core.Modules
{
    public class LifeCycleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {    
            builder.Register(transient => new Transient())
                .As<Transient>()
                .InstancePerDependency();

            builder.Register(scoped => new Scoped())
                .As<Scoped>()
                .InstancePerLifetimeScope();

            builder.Register(singleton => new Singleton())
                .As<Singleton>()
                .SingleInstance();
        }
    }
}
