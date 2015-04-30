using ClassLibrary1.CQRS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CQRS.Query
{
    public class GenericQuery<TSrcEntity> : IQuery<IEnumerable<TSrcEntity>>
    {
        public Expression<Func<TSrcEntity, bool>> Filter { get; set; }
        public Func<IQueryable<TSrcEntity>, IOrderedQueryable<TSrcEntity>> OrderBy { get; set; }
        public IEnumerable<string> IncludeProperties { get; set; }
    }
}
