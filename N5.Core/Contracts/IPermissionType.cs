using N5.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Contracts
{
    public interface IPermissionType
    {
        Task<List<PermissionType>> GetAllPermissionTypesAsync();
    }
}
