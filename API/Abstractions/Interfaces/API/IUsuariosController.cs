using Abstractions.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;


namespace Abstractions.Interfaces.API
{
    public interface IUsuariosController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid Id);
        Task<IActionResult> Agregar(UsuariosRequest usuario);
        Task<IActionResult> Editar(Guid Id, UsuariosRequest usuario);
        Task<IActionResult> Eliminar(Guid Id);
    }
}
