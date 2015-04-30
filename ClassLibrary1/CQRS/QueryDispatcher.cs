using ClassLibrary1.CQRS.Interface;
using ClassLibrary1.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CQRS
{
    public class QueryDispatcher:IQueryDispatcher
    {

        public TResult Dispatch<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>
        {
            var handler = DependencyResolver.Get<IQueryHandler<TQuery,TResult>>();
            return handler.Retreive(query);
        }
    }
}
