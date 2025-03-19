

using Abstractions.Interfaces.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IReaccionesDA
    {
        Task<IEnumerable<ReaccionesDetalle>> Obtener();
        Task<ReaccionesDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(ReaccionesRequest reaccion);
        Task<Guid> Editar(Guid Id, ReaccionesRequest reaccion);
        Task<Guid> Eliminar(Guid Id);
    }
}
