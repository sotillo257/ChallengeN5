using N5.Core.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Contracts
{
    public interface IPermissionServices
    {
        Task<PermissionResultDto> GetAllPermissionsAsync(PermissionResultDto permissionResult);
        Task<PermissionDto> AddPermissionAsync(PermissionAddDto permission);
        Task<bool> UpdatePermission(PermissionUpdateDto permissionDto);
    }
}
