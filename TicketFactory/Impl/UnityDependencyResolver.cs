using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Unity;

namespace TicketFactory.Impl
{
    class UnityDependencyResolver
    {
        private static readonly IUnityContainer _container;


        static UnityDependencyResolver()
        {
            _container = new UnityContainer();
        }
    }
}
