﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;


namespace YOYOFx.Extensions.DependencyInjection
{
    public class InjectServiceProvider : IServiceProvider, IDisposable
    {
        private IServiceProvider serviceProvider = null;


        public InjectServiceProvider(IServiceCollection serviceCollection)
        {
            this.serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public InjectServiceProvider(IServiceProvider sp)
        {
            this.serviceProvider = sp;
        }



        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            ((IDisposable)serviceProvider)?.Dispose();
        }

    }
}