using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.ModelsDto
{ 
    public class PermissionDto
    {
        public int PermissionID { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public int PermissionTypeID { get; set; }
        public DateTime FechaPermiso { get; set; }
        public virtual PermissionTypeDto PermissionType { get; set; }
        
    }
}
