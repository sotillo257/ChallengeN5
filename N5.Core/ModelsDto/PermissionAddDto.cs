using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.ModelsDto
{ 
    public class PermissionAddDto
    {
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public int PermissionTypeID { get; set; }
        
    }
}
