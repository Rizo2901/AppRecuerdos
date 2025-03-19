
using Abstractions.Interfaces.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IComentariosDA
    {
        Task<IEnumerable<ComentariosDetalle>> Obtener();
        Task<ComentariosDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(ComentariosRequest comentario);
        Task<Guid> Editar(Guid Id, ComentariosRequest comentario);
        Task<Guid> Eliminar(Guid Id);
    }
}
