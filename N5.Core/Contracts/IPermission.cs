using N5.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Contracts
{
    public interface IPermission
    {
        Task<List<T>> GetAllPermissionsAsync<T>(int page, int pageSize, string sortExpression, string filterExpression, Expression<Func<Permission, T>> projection);
        Task<Permission> AddPermissionAsync(Permission permission);
        void UpdatePermission(Permission permission);
        Task<Permission> GetPermissionsAsync(int Id);
    }
}
