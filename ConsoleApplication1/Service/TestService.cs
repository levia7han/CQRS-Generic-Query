using ClassLibrary1.CQRS.Interface;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.CQRS.Extensions;
using ClassLibrary1.ServiceInterfaces;

namespace ConsoleApplication1.Service
{
    public class TestService : ITestService
    {
        private readonly IQueryDispatcher _queryDispatcher;
        public TestService(IQueryDispatcher querydispatcher)
        {
            _queryDispatcher = querydispatcher;
        }

        public IEnumerable<ClassLibrary1.Models.Document> GetDocuments()
        {
            return _queryDispatcher.DispatchGenericQuery<Document>();
        }
    }
}
