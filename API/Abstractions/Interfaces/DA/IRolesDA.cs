

using Abstractions.Interfaces.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IRolesDA
    {
        Task<IEnumerable<RolesDetalle>> Obtener();
        Task<RolesDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(RolesRequest rol);
        Task<Guid> Editar(Guid Id, RolesRequest rol);
        Task<Guid> Eliminar(Guid Id);
    }
}
