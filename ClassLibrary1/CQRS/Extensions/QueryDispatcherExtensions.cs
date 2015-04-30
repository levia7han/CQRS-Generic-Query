using ClassLibrary1.CQRS.Interface;
using ClassLibrary1.CQRS.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CQRS.Extensions
{
    public static class QueryDispatcherExtensions
    {
        public static IEnumerable<TSrcEntity> DispatchGenericQuery<TSrcEntity>(
            this IQueryDispatcher queryDispatcher,
            Expression<Func<TSrcEntity, bool>> filter = null,
            Func<IQueryable<TSrcEntity>, IOrderedQueryable<TSrcEntity>> orderBy = null,
            params string[] includeProperties)
            where TSrcEntity : class
        {
            return queryDispatcher.Dispatch<GenericQuery<TSrcEntity>, IEnumerable<TSrcEntity>>(new GenericQuery<TSrcEntity>
            {
                Filter = filter,
                OrderBy = orderBy,
                IncludeProperties = includeProperties
            });
        }
    }
}
