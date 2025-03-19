

using Abstractions.Interfaces.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IRecuerdosDA
    {
        Task<IEnumerable<RecuerdosDetalle>> Obtener();
        Task<RecuerdosDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(RecuerdosRequest recuerdo);
        Task<Guid> Editar(Guid Id, RecuerdosRequest recuerdo);
        Task<Guid> Eliminar(Guid Id);
    }
}
