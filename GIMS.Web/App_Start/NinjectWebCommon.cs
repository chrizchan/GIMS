using GIMS.Repository;
using GIMS.ServiceLayer;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GIMS.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GIMS.Web.App_Start.NinjectWebCommon), "Stop")]

namespace GIMS.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IItemRepository>().To<ItemRepository>();
            kernel.Bind<IItemAdditionalInformationRepository>().To<ItemAdditionalInformationRepository>();
            kernel.Bind<IBranchStockRepository>().To<BranchStockRepository>();
            kernel.Bind<IXRefRepository>().To<XRefRepository>();
            kernel.Bind<IItemRCInformationRepository>().To<ItemRCInformationRepository>();
            kernel.Bind<IHQStockStatusRepository>().To<HQStockStatusRepository>();

            kernel.Bind<IItemAdditionalInformationService>().To<ItemAdditionalInformationService>();
            kernel.Bind<IItemService>().To<ItemService>();
            kernel.Bind<IBranchStockService>().To<BranchStockService>();
            kernel.Bind<IXRefService>().To<XRefService>();
            kernel.Bind<IItemRCInformationService>().To<ItemRCInformationService>();
            kernel.Bind<IHQStockStatusService>().To<HQStockStatusService>();
        }        
    }
}
