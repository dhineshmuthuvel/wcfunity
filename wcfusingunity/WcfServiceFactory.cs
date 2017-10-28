using Microsoft.Practices.Unity;
using Unity.Wcf;
using wcfusingunity.Dependencies;

namespace wcfusingunity
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IService, Service>();
            container.RegisterType<IDependency, Dependency>();
        }
    }    
}