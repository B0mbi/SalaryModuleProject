using System.Web.Mvc;
using SalaryModuleProject.Repositories;
using Unity;
using Unity.Mvc5;

namespace SalaryModuleProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<ITransactionRepository, TransactionRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}