using System;
using System.Runtime.Caching;
using Ninject.Modules;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Integration;

namespace NrlWebServiceWrapper.Ninject
{
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ICacheItemPolicyGenerator>().To<CacheItemPolicyGenerator>();
            GenerateAndBindNrlCache();
            Kernel.Bind<IFridayNightResolver>().To<FridayNightResolver>();
            GenerateAndBindNrlRepository();
        }

        private void GenerateAndBindNrlCache()
        {
            MemoryCache memoryCache = new MemoryCache("NrlCache");
            Kernel.Bind<INrlCache>()
                .To<NrlCache>()
                .InSingletonScope()
                .WithConstructorArgument("memoryCache", memoryCache);
        }

        private void GenerateAndBindNrlRepository()
        {
            Uri webServiceEndPoint = new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx");
            const int clientId = 151;
            Kernel.Bind<INrlRepository>()
                .To<NrlRepository>()
                .WithConstructorArgument("endpoint", webServiceEndPoint)
                .WithConstructorArgument("clientId", clientId);
        }
    }
}