using N5.Core.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Contracts
{
    public interface IPermissionTypeServices
    {
        Task<List<PermissionTypeDto>> GetAllPermissionTypesAsync();
    }
}
