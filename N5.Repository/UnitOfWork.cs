using Microsoft.EntityFrameworkCore;
using N5.Core.Contracts;
using N5.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Repository
{
    public class UnitOfWork : BaseUnitOfWork, IUnitOfWork
    {
        private IPermission _Permission;
        private IPermissionType _PermissionType;
        public UnitOfWork(DefaultContext context) : base(context)
        {
        }

        public IPermission permission => _Permission ??= new PermissionRepository(_context);
        public IPermissionType permissionType => _PermissionType ??= new PermissionTypeRepository(_context);
    }
}
