using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Contracts
{
    public interface IUnitOfWork : IBaseUnitOfWork
    {
        IPermission permission { get; }
        IPermissionType permissionType { get; }
    }
}
