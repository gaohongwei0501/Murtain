﻿using Microsoft.AspNet.SignalR;
using Murtain.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murtain.Web.SignalR
{
    public class SignalRDependencyResolver : DefaultDependencyResolver
    {
        public override object GetService(Type serviceType)
        {
            if (IocManager.Container.IsRegistered(serviceType))
            {
                return IocManager.Container.Resolve(serviceType);
            }
            return base.GetService(serviceType);
        }
    }
}
