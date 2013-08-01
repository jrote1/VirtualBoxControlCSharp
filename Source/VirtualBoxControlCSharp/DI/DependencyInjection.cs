﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Ninject;
using NinjectAdapter;

namespace VirtualBoxControlCSharp.DI
{
    public class DependencyInjection
    {
        public static void Initialize()
        {
            var kernel = new StandardKernel();
            var locator = new NinjectServiceLocator(kernel);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
