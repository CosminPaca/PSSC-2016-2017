using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Query
{
    public interface IQueryDispatcher
    {
        TResult Execute<TQuery, TResult>(TQuery query)
            where TQuery : IQuery<TResult>;
    }
}
