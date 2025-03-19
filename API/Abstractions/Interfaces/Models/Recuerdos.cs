
namespace Abstractions.Interfaces.Models
{
    public class RecuerdosBase
    {
        public Guid IdRecuerdo { get; set; }
        public Guid IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
    }

    public class RecuerdosRequest : RecuerdosBase
    {
        public Guid IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }

    }

    public class RecuerdosDetalle : RecuerdosBase
    {
        public Guid IdRecuerdo { get; set; }
        public Guid IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }

    }


}
