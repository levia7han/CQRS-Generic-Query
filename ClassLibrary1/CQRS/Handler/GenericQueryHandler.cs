using ClassLibrary1.CQRS.Interface;
using ClassLibrary1.CQRS.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CQRS.Handler
{
    public class GenericQueryHandler<TSrcEntity> : IQueryHandler<GenericQuery<TSrcEntity>, IEnumerable<TSrcEntity>> where TSrcEntity : class
    {
        public IEnumerable<TSrcEntity> Retreive(GenericQuery<TSrcEntity> query)
        {
            return GetDocuments();
        }

        private IEnumerable<TSrcEntity> GetDocuments()
        {
            //This does nothing. But return a null value in a list.
            dynamic a = new System.Dynamic.ExpandoObject();
            a.Id = new Guid();
            a.Name = "Test";
            var list = new List<TSrcEntity>();
            list.Add(a as TSrcEntity);
            return list;
        }
    }
}
