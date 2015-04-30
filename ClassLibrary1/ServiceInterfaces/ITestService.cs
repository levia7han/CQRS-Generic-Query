using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ServiceInterfaces
{
    public interface ITestService
    {
        IEnumerable<Document> GetDocuments(); 
    }
}
