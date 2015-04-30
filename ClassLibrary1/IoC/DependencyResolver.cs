using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.IoC
{
    public static class DependencyResolver
    {
        private static IServiceContainer _serviceContatiner;

        public static void SetResolver(IServiceContainer serviceContatiner)
        {
            _serviceContatiner = serviceContatiner;
        }

        public static T Get<T>()
        {
            return _serviceContatiner.GetInstance<T>();
        }
    }
}
