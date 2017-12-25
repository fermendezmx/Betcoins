using Autofac;
using Autofac.Integration.WebApi;
using Betcoins.BusinessLogic.Contracts;
using Betcoins.BusinessLogic.Implementations;
using Betcoins.Repositories.Contracts;
using Betcoins.Repositories.Implementations;
using System.Reflection;
using System.Web.Http;

namespace Betcoins.Web.Bootstrap
{
    public static class AutofacFactory
    {
        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            // Get your HttpConfiguration.
            HttpConfiguration config = GlobalConfiguration.Configuration;

            // Register Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // Register services
            builder.RegisterType<AccountService>().As<IAccountService>().InstancePerRequest();

            // Register repositories
            builder.RegisterType<AccountRepository>().As<IAccountRepository>().InstancePerRequest();

            // Set the dependency resolver to be Autofac.
            IContainer container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}