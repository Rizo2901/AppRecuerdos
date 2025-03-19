using Abstractions.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.API
{
    public interface IFavoritosController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid Id);
        Task<IActionResult> Agregar(FavoritosRequest favorito);
        Task<IActionResult> Editar(Guid Id, FavoritosRequest favorito);
        Task<IActionResult> Eliminar(Guid Id);
    }
}
