using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Components;
using Ninject.Modules;
using CustomerManagementSystem.Services;

namespace CustomerManagementSystem
{
    public class IoC : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerService>().InTransientScope();
        }
    }
}
