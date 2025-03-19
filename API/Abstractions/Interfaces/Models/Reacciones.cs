using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Models
{
    public class ReaccionesBase
    {
        public Guid IdReaccion { get; set; }
        public Guid IdRecuerdo { get; set; }
        public Guid? IdUsuario { get; set; }
        public string TipoReaccion { get; set; }
    }

    public class ReaccionesRequest : ReaccionesBase
    {
        public Guid IdRecuerdo { get; set; }
        public Guid? IdUsuario { get; set; }
        public string TipoReaccion { get; set; }
    }

    public class ReaccionesDetalle : ReaccionesBase
    {
        public Guid IdReaccion { get; set; }
        public Guid IdRecuerdo { get; set; }
        public Guid? IdUsuario { get; set; }
        public string TipoReaccion { get; set; }
    }

}
