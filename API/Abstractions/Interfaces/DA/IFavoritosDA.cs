

using Abstractions.Interfaces.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IFavoritosDA
    {
        Task<IEnumerable<FavoritosDetalle>> Obtener();
        Task<FavoritosDetalle> Obtener(Guid Id);
        Task<Guid> Agregar(FavoritosRequest favorito);
        Task<Guid> Editar(Guid Id, FavoritosRequest favorito);
        Task<Guid> Eliminar(Guid Id);
    }
}
