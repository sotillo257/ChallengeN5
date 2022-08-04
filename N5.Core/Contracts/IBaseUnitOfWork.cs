using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Contracts
{
    public interface IBaseUnitOfWork
    {
        Task<T> TransactionallyDo<T>(Func<Task<T>> asyncAction, System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.ReadCommitted);
        Task TransactionallyDo(Func<Task> asyncAction, System.Data.IsolationLevel isolationLevel = System.Data.IsolationLevel.ReadCommitted);
        Task<int> CommitAsync();
    }
}
