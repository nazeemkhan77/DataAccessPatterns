using System.Collections.Generic;

namespace Patterns.DataAccess.Query
{
    interface IQueryExecuter
    {
        IList<T> Execute<T>(IQuery<T> query);
    }
}
