using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Models
{
    public class ComentariosBase
    {
        public Guid IdComentario { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdRecuerdo { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class ComentariosRequest : ComentariosBase
    {
        public Guid IdUsuario { get; set; }
        public Guid IdRecuerdo { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class ComentariosDetalle : ComentariosBase
    {
        public Guid IdComentario { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdRecuerdo { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
