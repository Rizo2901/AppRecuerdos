using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Models
{
    public class RolesBase
    {
        public Guid IdRol { get; set; }
        public string Nombre { get; set; }
    }

    public class RolesRequest : RolesBase
    {
        public string Nombre { get; set; }
    }

    public class RolesDetalle : RolesBase
    {
        public Guid IdRol { get; set; }
        public string Nombre { get; set; }
    }
}
