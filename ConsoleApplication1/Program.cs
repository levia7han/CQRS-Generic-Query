using ClassLibrary1.CQRS;
using ClassLibrary1.CQRS.Handler;
using ClassLibrary1.CQRS.Interface;
using ClassLibrary1.CQRS.Query;
using ClassLibrary1.IoC;
using ClassLibrary1.Models;
using ClassLibrary1.ServiceInterfaces;
using ConsoleApplication1.Service;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ServiceContainer();
            
            //service
            container.Register<ITestService, TestService>();
            
            //query
            container.Register(typeof(IQuery<>), typeof(GenericQuery<>));

            //handler This one works, but I dont want to register everything explicity.
            container.Register(typeof(IQueryHandler<GenericQuery<Document>, IEnumerable<Document>>), typeof(GenericQueryHandler<Document>));
            
            //dispatcher
            container.Register<IQueryDispatcher, QueryDispatcher>();

            DependencyResolver.SetResolver(container);

            var service = container.GetInstance<ITestService>();

            var a = service.GetDocuments();

        }
    }
}
