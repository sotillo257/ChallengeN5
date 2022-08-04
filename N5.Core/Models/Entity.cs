using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Core.Models
{
    public class Entity<TIdentifier>
    {
        public TIdentifier Id { get; set; }
    }
}
