using Ninject.Modules;

namespace NrlWebServiceWrapper.Ninject
{
    public static class NinjectHttpModules
    {
        public static INinjectModule[] Modules
        {
            get
            {
                return new INinjectModule[]
                {
                    new MainModule()
                };
            }
        }
    }
}