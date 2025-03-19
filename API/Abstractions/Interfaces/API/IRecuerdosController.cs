using Abstractions.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.API
{
    public interface IRecuerdosController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid Id);
        Task<IActionResult> Agregar(RecuerdosRequest recuerdo);
        Task<IActionResult> Editar(Guid Id, RecuerdosRequest recuerdo);
        Task<IActionResult> Eliminar(Guid Id);
    }
}
