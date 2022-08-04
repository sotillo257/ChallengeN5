using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.ModelsDto
{
    public class PermissionResultDto
    {
        public List<PermissionDto> Permissions { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
    }
}
