using Abstractions.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;


namespace Abstractions.Interfaces.API
{
    public interface IRolesController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid Id);
        Task<IActionResult> Agregar(RolesRequest rol);
        Task<IActionResult> Editar(Guid Id, RolesRequest rol);
        Task<IActionResult> Eliminar(Guid Id);
    }
}
