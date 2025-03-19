using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Models
{
    public class FavoritosBase
    {
        public Guid IdFavorito { get; set; }
        public Guid IdRecuerdo { get; set; }
        public Guid? IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class FavoritosRequest : FavoritosBase
    {
        public Guid IdRecuerdo { get; set; }
        public Guid? IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class FavoritosDetalle : FavoritosBase
    {
        public Guid IdFavorito { get; set; }
        public Guid IdRecuerdo { get; set; }
        public Guid? IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
