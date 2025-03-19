using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Models
{
    public class UsuariosBase
    {
        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string ContraseñaHash { get; set; }
        public Guid IdRol { get; set; }
    }

    public class UsuariosRequest : UsuariosBase
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string ContraseñaHash { get; set; }
        public Guid IdRol { get; set; }
    }

    public class UsuariosDetalle : UsuariosBase
    {
        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string ContraseñaHash { get; set; }
        public Guid IdRol { get; set; }
    }

}
