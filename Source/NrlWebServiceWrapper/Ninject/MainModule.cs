using System;
using Ninject.Modules;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Integration;

namespace NrlWebServiceWrapper.Ninject
{
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            Uri webServiceEndPoint = new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx");
            const int clientId = 151;
            Kernel.Bind<INrlRepository>()
                .To<NrlRepository>()
                .WithConstructorArgument("endpoint", webServiceEndPoint)
                .WithConstructorArgument("clientId", clientId);
            Kernel.Bind<IFridayNightResolver>().To<FridayNightResolver>();
        }
    }
}